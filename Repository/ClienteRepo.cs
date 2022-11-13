using atividadeAvaliativaModulo6.Database;
using atividadeAvaliativaModulo6.Model;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Cliente> GetClienteById(int id)
        {
            return await _context.Cliente.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _context.Cliente.ToListAsync();
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