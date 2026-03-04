using Microsoft.AspNetCore.Mvc;

namespace Oitavo.Controllers;

[ApiController]
[Route("[controller]")]
public class VerificaIdadeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetIdade([FromQuery] int idade)
    {
        string resposta;

        if (idade >= 20)
        {
            resposta = "Pode entrar no cinema.";
        }
        else
        {
            resposta = "Você não está liberado para acessar o cinema.";
        }

        return Ok(resposta);
    }
}
