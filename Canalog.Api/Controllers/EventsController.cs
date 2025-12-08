using System.Security.Claims;
using Canalog.Application;
using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly IEventService _eventService;
    private readonly UserService _userService;

    public EventsController(IEventService eventService, UserService userService)
    {
        _eventService = eventService;
        _userService = userService;
    }

    [HttpGet("today")]
    public async Task<IActionResult> GetTodayEvents()
    {
        var user = await GetUserAsync();
        if (user is null)
        {
            return Unauthorized("User not found or not authenticated.");
        }

        var events = await _eventService.GetTodaysEventAsync(user);
        return Ok(events);
    }

    [HttpGet("week")]
    public async Task<IActionResult> GetWeekEvents([FromQuery] DateTime? start)
    {
        var user = await GetUserAsync();
        if (user is null)
        {
            return Unauthorized("User not found or not authenticated.");
        }

        var startDate = start?.Date ?? DateTime.Today;
        var events = await _eventService.GetWeekEventAsync(user, startDate);

        return Ok(events);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] EventRequestDto request)
    {
        var user = await GetUserAsync();
        if (user is null)
        {
            return Unauthorized("User not found or not authenticated.");
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
            return StatusCode(500, "Failed to save event to the database.");
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
        var userId = User.FindFirst("sub")?.Value;
        if (string.IsNullOrEmpty(userId))
            return null;

        return await _userService.FindByIdAsync(userId);
    }
}
