using System.Security.Claims;
using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Api.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly IEventService _eventService;
    private readonly IUserService _userService;


    public EventsController(IEventService eventService, IUserService userService)
    {
        _eventService = eventService;
        _userService = userService;
    }

    [HttpGet("today")]
    public async Task<IActionResult> GetToday()
    {
        var user = await GetUserAsync();
        if (user is null)
        {
            return Unauthorized("User not found");
        }

        var events = await _eventService.GetTodayAsync(user);
        return Ok(events);
    }

    [HttpGet("week")]
    public async Task<IActionResult> GetRange([FromQuery] DateTime? start)
    {
        var user = await GetUserAsync();
        if (user is null)
        {
            return NotFound("User not found");
        }

        var startDate = start?.Date ?? DateTime.Today;
        var events = await _eventService.GetRangeAsync(user, startDate);

        return Ok(events);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] EventRequestDto request)
    {
        var user = await GetUserAsync();
        if (user is null)
        {
            return NotFound("User not found");
        }

        try
        {
            var createdEvent = await _eventService.CreateAsync(request, user);
            return Ok(createdEvent);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (DbUpdateException)
        {
            return BadRequest("Failed to save event to the database.");
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateEventRequestDto request)
    {
        try
        {
            await _eventService.UpdateAsync(request);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound($"Event with id '{request.EventId}' was not found.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (DbUpdateException)
        {
            return BadRequest("Failed to update event in the database.");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        if (!Guid.TryParse(id, out var guid))
            return BadRequest("Invalid event id.");

        try
        {
            await _eventService.DeleteAsync(guid);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound($"Event with id '{id}' was not found.");
        }
        catch (DbUpdateException)
        {
            return BadRequest("Failed to delete event from the database.");
        }
    }

    private async Task<User?> GetUserAsync()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return null;

        return await _userService.FindByIdAsync(userId);
    }
}
