using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.SecurityAspNetCore.Controllers
{
    [Route("admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [Authorize(Policy = "Admin")] // Requer autorização com a política "Admin"
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // Retorna uma resposta de sucesso com uma mensagem
            return Ok(new { message = "Bem-vindo ao painel de administração!" });
        }
    }
}
