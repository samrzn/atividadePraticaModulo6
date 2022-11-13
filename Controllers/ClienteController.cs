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
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _repository.GetClientes();
            return clientes.Any() ? Ok(clientes) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _repository.GetClienteById(id);
            return cliente != null ? Ok(cliente) : NotFound("Cliente não encontrado.");
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