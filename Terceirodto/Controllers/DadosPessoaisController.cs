using Microsoft.AspNetCore.Mvc;
using Terceirodto.Dtos;
using Terceirodto.Services;

namespace Terceirodto.Controllers;

[ApiController]
[Route("[controller]")]
public class DadosPessoaisController : ControllerBase
{
    [HttpPost]
    public IActionResult DadosPessoais([FromBody] PessoaDto dto)
    {
        var service = new PessoaService();
        var resultado = service.VerificarDados(dto);

        return Ok(resultado);
    }
}
