using atividadeAvaliativaModulo6.Database;
using atividadeAvaliativaModulo6.Model;

namespace atividadeAvaliativaModulo6.Repository
{
    public class ClienteRepo : IClienteRepository
    {
        private readonly ClienteDbContext _context;
        public ClienteRepo(ClienteDbContext context)
        {
            _context = context;
        }
        public void AddCliente(Cliente cliente)
        {
            _context.Add(cliente);
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetClientes()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}