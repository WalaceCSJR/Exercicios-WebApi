using Microsoft.AspNetCore.Mvc;
using Segundodto.Dtos;
using Segundodto.Services;

namespace Segundodto.Controllers;

[ApiController]
[Route("[controller]")]
public class VerificacaoMaioridadeController : ControllerBase
{
    [HttpPost]
    public IActionResult VerificacaoMaioridade([FromBody] PessoaDto dto)
    {
        var services = new PessoaService();
        bool resultado = services.VerificacaoMaioridade(dto.Idade);
        return Ok(resultado);
    }
}
