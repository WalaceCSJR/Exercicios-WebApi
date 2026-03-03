using Microsoft.AspNetCore.Mvc;

namespace Terceiro.Controllers;

[ApiController]
[Route("[controller]")]
public class NumeroRandomController : ControllerBase
{
    [HttpGet]
    public IActionResult GetNumeroAleatorio()
    {
        int NumeroRandom = Random.Shared.Next(1, 100);
        return Ok(NumeroRandom);
    }
}
