using Microsoft.AspNetCore.Mvc;

namespace Segundo.Controllers;

[ApiController]
[Route("[controller]")]
public class GetDezController : ControllerBase
{
    [HttpGet]
    public IActionResult GetDez()
    {
        var Resultado = new GetDez{ Numero = 10};
        return Ok(Resultado);
    }
}
