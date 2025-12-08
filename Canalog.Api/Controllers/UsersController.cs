using Canalog.Application;
using Canalog.Application.Dtos;
using Canalog.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(UserService userService) : ControllerBase
{
    private readonly UserService _userService = userService;


    [HttpGet("sync")]
    public async Task<ActionResult<OptionsResponseDto>> Sync()
    {
        var userId = User.FindFirst("sub")?.Value;
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

