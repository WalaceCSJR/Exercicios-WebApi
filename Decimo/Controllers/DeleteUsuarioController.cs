using Microsoft.AspNetCore.Mvc;

namespace Decimo.Controllers;

[ApiController]
[Route("[controller]")]
public class DeleteUsuarioController : ControllerBase
{
    [HttpDelete]
    public IActionResult DeleteUsuario([FromQuery] int id)
    {
        string resposta = "O Usuario do ID " + id + " foi deletado.";
        return Ok(resposta);
    }
}
