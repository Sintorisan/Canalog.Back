using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController(IEventService service) : ControllerBase
{
    private readonly IEventService _service = service;

    [HttpGet("today")]
    public async Task<ActionResult<EventResponseDto>> GetTodays()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> Create(EventRequestDto request)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        throw new NotImplementedException();
    }
}

