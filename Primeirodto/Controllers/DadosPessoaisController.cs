using Microsoft.AspNetCore.Mvc;
using Primeirodto.Dtos;

namespace Primeirodto.Controllers;

[ApiController]
[Route("[controller]")]
public class DadosPessoaisController : ControllerBase
{
    [HttpPost]
    public IActionResult DadosPessoais([FromBody] PessoaDto dto)
    {
        return Ok(dto);
    }
}
