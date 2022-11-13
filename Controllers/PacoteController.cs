using atividadeAvaliativaModulo6.Model;
using atividadeAvaliativaModulo6.Repository;
using Microsoft.AspNetCore.Mvc;

namespace atividadeAvaliativaModulo6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacoteController : ControllerBase
    {
   private readonly IPacoteRepository _repository;
        public PacoteController(IPacoteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pacotes = await _repository.GetPacotes();
            return pacotes.Any() ? Ok(pacotes) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id_pacote)
        {
            var pacote = await _repository.GetPacoteById(id_pacote);
            return pacote != null ? Ok(pacote) : NotFound("Pacote não encontrado.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pacote pacote)
        {
            _repository.AddPacote(pacote);
            return await _repository.SaveChangesAsync()
            ? Ok("Pacote cadastrado.") : BadRequest("Impossível realizar cadastro no momento, tente mais tarde.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePacote(int id_pacote)
        {
            var pacoteExists = await _repository.GetPacoteById(id_pacote);
            if (pacoteExists == null)
                return NotFound("Pacote não encontrado.");

            _repository.DeletePacote(pacoteExists);

            return await _repository.SaveChangesAsync() ? Ok("Pacote excluído.") :
            BadRequest("Não foi possível excluir pacote.");
        }

    }
}