using System.Security.Claims;
using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class OptionsController(IOptionsService optionsService) : ControllerBase
{
    private readonly IOptionsService _optionsService = optionsService;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("themes")]
    public async Task<ActionResult<List<ThemeListItemDto>>> GetThemes()
    {
        var themes = await _optionsService.GetAllThemesAsync();
        return Ok(themes);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateThemeRequestDto request)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return BadRequest();
        }

        await _optionsService.UpdateAsync(request, userId);
        return Ok();
    }
}

