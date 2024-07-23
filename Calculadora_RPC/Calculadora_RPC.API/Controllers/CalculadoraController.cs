using Microsoft.AspNetCore.Mvc;

namespace Calculadora_RPC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost("Somar")]
        public IActionResult Somar123()
        {
            return Ok();
        }

        [HttpPost("Subtrair")]
        public IActionResult Subtrair()
        {
            return Ok();
        }

        [HttpPost("Multiplicar")]
        public IActionResult Multiplicar()
        {
            return Ok();
        }

        [HttpPost("Dividir")]
        public IActionResult Dividir()
        {
            return Ok();
        }
    }
}
