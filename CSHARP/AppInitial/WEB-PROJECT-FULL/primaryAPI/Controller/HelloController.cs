using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace primaryAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
    }
}
