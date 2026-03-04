using Microsoft.AspNetCore.Mvc;

namespace Nono.Controllers;

[ApiController]
[Route("[controller]")]
public class RecebeIdadeController : ControllerBase
{
    [HttpPost]
    public IActionResult PostIdade([FromQuery] int idade)
    {
        return Ok(idade);
    }
}
