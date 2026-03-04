using Microsoft.AspNetCore.Mvc;

namespace Sexto.Controllers;

[ApiController]
[Route("[controller]")]
public class NomeUsuarioController : ControllerBase
{
    [HttpGet]
    public ActionResult GetNome([FromQuery] string Nome)
    {
        var resultado = new NomeUsuario
        {
            Nome = Nome
        };

        return Ok(resultado);
    }
}
