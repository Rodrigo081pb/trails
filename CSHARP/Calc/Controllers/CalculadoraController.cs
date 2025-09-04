using Microsoft.AspNetCore.Mvc;

namespace Calc.Controllers
{
    public class CalculadoraController : Controller
    {

        [HttpPost("api/somar")]
        // passando 2 parametros via body
        public IActionResult Somar([FromBody] int num1, [FromBody] int num2)
        {
            var resultado = num1 + num2;
            return Ok(resultado);
        }

    }

}
