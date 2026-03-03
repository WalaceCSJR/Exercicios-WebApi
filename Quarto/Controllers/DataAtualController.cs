using Microsoft.AspNetCore.Mvc;

namespace Quarto.Controllers;

[ApiController]
[Route("[controller]")]
public class DataAtualController : ControllerBase
{
    [HttpGet]
    public IActionResult GetDataAtual()
    {
        var DataAtual = DateTime.Now;
        return Ok(DataAtual);
    }
}
