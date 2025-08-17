using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies; // Importa o namespace para autenticação com cookies
using Microsoft.AspNetCore.Http; // Importa o namespace para manipulação de requisições HTTP
using Microsoft.AspNetCore.Mvc; // Importa o namespace para controle de APIs
using System.Security.Claims; // Importa o namespace para manipulação de reivindicações (claims)

namespace Project.SecurityAspNetCore.Controllers // Namespace para o controlador de autenticação
{
    [Route("account")] // Define a rota base para o controlador
    [ApiController] // Define que esta classe é um controlador de API
    public class AccountController : ControllerBase // Classe que herda de ControllerBase para criar um controlador de API
    {
        [HttpPost("login")] // Define o método HTTP POST para a rota "account/login"
        public async Task<IActionResult> Login(string usuario, string senha)
        {
           // validar crendenciais do usuario
           if(usuario == "admin" && senha == "123456") 
           {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario),
                    new Claim("Admin", "true"),
                    
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties {IsPersistent = true};
                await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimIdentity), authProperties);
                
                return Ok(new { message = "Login bem-sucedido!" });

            } else if(usuario == "user" && senha == "232916"){
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,usuario),
                    new Claim("User", "true")
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties { IsPersistent = true };
                await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimIdentity), authProperties);

                return Ok(new { message = "Login bem-sucedido!" });

            } else
            {
                return Unauthorized(new { message = "Usuário ou senha inválidos." });
            }

        }
    }
}
