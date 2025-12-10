using System.Security.Claims;
using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [Authorize]
    [HttpGet("sync")]
    public async Task<ActionResult<OptionsResponseDto>> Sync()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return BadRequest();
        }

        var user = await _userService.FindByIdAsync(userId);
        if (user is null)
        {
            user = await _userService.CreateAsync(userId);
        }

        var response = _userService.MapResponse(user);

        return Ok(response);
    }
}

