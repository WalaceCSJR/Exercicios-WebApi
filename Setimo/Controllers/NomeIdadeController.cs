using Microsoft.AspNetCore.Mvc;

namespace Setimo.Controllers;

[ApiController]
[Route("[controller]")]
public class NomeIdadeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetNomeIdade([FromQuery] string nome, [FromQuery] int idade)
    {
        string sufixoIdade;

        if (idade == 1)
        {
            sufixoIdade = "Ano";
        }
        else
        {
            sufixoIdade = "Anos";
        }

        string frase = "O(A) " + nome + " Tem " + idade + " " + sufixoIdade;
        
        return Ok(frase);
    }
}
