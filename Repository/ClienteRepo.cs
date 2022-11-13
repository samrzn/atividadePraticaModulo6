using atividadeAvaliativaModulo6.Database;
using atividadeAvaliativaModulo6.Model;
using Microsoft.EntityFrameworkCore;

namespace atividadeAvaliativaModulo6.Repository
{
    public class ClienteRepo : IClienteRepository
    {
        private readonly TripDbContext _context;
        public ClienteRepo(TripDbContext context)
        {
            _context = context;
        }
        public void AddCliente(Cliente cliente)
        {
            _context.Add(cliente);
        }

        public void DeleteCliente(Cliente cliente)
        {
            _context.Remove(cliente);
        }

        public async Task<Cliente> GetClienteById(int id_cliente)
        {
            return await _context.Cliente.Where(x => x.Id_cliente == id_cliente).FirstOrDefaultAsync();
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
            _context.Update(cliente);
        }
    }
}