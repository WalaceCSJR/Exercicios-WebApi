using Microsoft.AspNetCore.Mvc;

namespace Quinto.Controllers;

[ApiController]
[Route("[controller]")]
public class DataAtualComNumeroRandomController : ControllerBase
{
    [HttpGet]
    public IActionResult GetDataAtualComNumeroRandom()
    {
        var resultado = new DataAtualComNumeroRandom
        {
            DataAtual = DateTime.Now,
            NumeroAleatorio = Random.Shared.Next(1, 500)
        };

        return Ok(resultado);
    }
}
