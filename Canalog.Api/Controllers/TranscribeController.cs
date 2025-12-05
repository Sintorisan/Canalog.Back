using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Canalog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TranscribeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Transcribe()
    {
        throw new NotImplementedException();
    }
}

