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
public class EventsController(IEventService eventService, UserService userService) : ControllerBase
{
    private readonly IEventService _eventService = eventService;
    private readonly UserService _userService = userService;

    [HttpGet("today")]
    public async Task<ActionResult<EventResponseDto>> GetTodayEvents()
    {
        var user = GetUserAsync();
        if (user == null)
        {
            return BadRequest();
        }

        var result = await _eventService.GetTodaysEventAsync();

        return Ok(result);
    }

    [HttpGet("week")]
    public async Task<ActionResult<EventResponseDto>> GetWeekEvents()
    {
        var result = await _eventService.GetWeekEventAsync();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(EventRequestDto request)
    {
        try
        {
            var response = await _eventService.CreateAsync(request);

            return Created();
        }
        catch (DbUpdateException)
        {
            return BadRequest("Database update failed.");
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id)
    {
        if (!Guid.TryParse(id, out Guid guid))
        {
            return BadRequest("Invalid Id");
        }

        try
        {
            await _eventService.UpdateAsync(guid);

            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (DbUpdateException)
        {
            return BadRequest("Database update failed.");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        if (!Guid.TryParse(id, out Guid guid))
        {
            return BadRequest("Invalid Id");
        }

        try
        {
            await _eventService.DeleteAsync(guid);

            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (DbUpdateException)
        {
            return BadRequest("Database update failed.");
        }
    }

    private async Task<User?> GetUserAsync()
    {
        var userId = User.FindFirst("sub")?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return null;
        }

        var user = await _userService.FindByIdAsync(userId);
        if (user is null)
        {
            return null;
        }
        return user;
    }

}

