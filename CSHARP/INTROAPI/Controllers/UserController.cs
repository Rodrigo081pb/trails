using Microsoft.AspNetCore.Mvc;

namespace INTROAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        [HttpGet("ObterDataHora")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {

                DataHoraAtual = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
            };

            return Ok(obj);
        }

        [HttpPost("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var menssagem = $"Olá {nome}, seja bem vindo(a)!";
            return Ok(new { menssagem });
        }

        [HttpPost("Usuario")]
        public IActionResult Usuario([FromBody] Models.Usuario usuario)
        {
            var menssagem = $"Olá {usuario.Nome}, você tem {usuario.Idade} anos.";
            return Ok(new { menssagem });
        }

        [HttpPost("Calcular")]
        public ActionResult Calcular(int num1, int num2)
        {
            var soma = num1 + num2;
            return Ok(new { soma });
        }

    }
}
