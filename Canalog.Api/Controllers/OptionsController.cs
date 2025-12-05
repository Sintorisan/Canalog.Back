using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OptionsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("themes")]
    public async Task<IActionResult> GetThemes()
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    public async Task<IActionResult> Update()
    {
        throw new NotImplementedException();
    }
}

