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

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var menssagem = $"Olá {nome}, seja bem vindo(a)!";
            return Ok(new { menssagem });
        }

    }
}
