using Microsoft.AspNetCore.Mvc;

namespace atividadeAvaliativaModulo6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public string Hello() {
            return "Olé";
        }
    }
}