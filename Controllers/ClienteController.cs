using atividadeAvaliativaModulo6.Model;
using atividadeAvaliativaModulo6.Repository;
using Microsoft.AspNetCore.Mvc;

namespace atividadeAvaliativaModulo6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        public ClienteController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public string Hello()
        {
            return "Olé";
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cliente cliente)
        {
            _repository.AddCliente(cliente);
            return await _repository.SaveChangesAsync()
            ? Ok("Cliente cadastrado.") : BadRequest("Impossível realizar cadastro no momento, tente mais tarde.");
        }

    }
}