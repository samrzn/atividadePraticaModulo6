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
        public async Task<IActionResult> GetById(int id_cliente)
        {
            var cliente = await _repository.GetClienteById(id_cliente);
            return cliente != null ? Ok(cliente) : NotFound("Cliente não encontrado.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cliente cliente)
        {
            _repository.AddCliente(cliente);
            return await _repository.SaveChangesAsync()
            ? Ok("Cliente cadastrado.") : BadRequest("Impossível realizar cadastro no momento, tente mais tarde.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCliente(int id_cliente, Cliente cliente)
        {
            var clienteExists = await _repository.GetClienteById(id_cliente);
            if (clienteExists == null) return NotFound("Cliente não encontrado");

            clienteExists.Nome = cliente.Nome ?? clienteExists.Nome;
            clienteExists.Telefone = cliente.Telefone ?? clienteExists.Telefone;
            clienteExists.Email = cliente.Email ?? clienteExists.Email;
            clienteExists.Cpf = cliente.Cpf ?? clienteExists.Cpf;
            clienteExists.Senha = cliente.Senha ?? clienteExists.Senha;

            return await _repository.SaveChangesAsync() ? Ok("Cadastro de cliente atualizado.") :
            BadRequest("Não foi possível atualizaro cadastro.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id_cliente)
        {
            var clienteExists = await _repository.GetClienteById(id_cliente);
            if (clienteExists == null)
                return NotFound("Cadastro não encontrado.");

            _repository.DeleteCliente(clienteExists);

            return await _repository.SaveChangesAsync() ? Ok("Cadastro excluído.") :
            BadRequest("Não foi possível apagar o cadastro do cliente.");
        }

    }
}