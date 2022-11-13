using atividadeAvaliativaModulo6.Database;
using atividadeAvaliativaModulo6.Model;
using Microsoft.EntityFrameworkCore;

namespace atividadeAvaliativaModulo6.Repository
{
    public class PacoteRepo : IPacoteRepository
    {
        private readonly TripDbContext _context;
        public PacoteRepo(TripDbContext context)
        {
            _context = context;
        }
        public void AddPacote(Pacote pacote)
        {
            _context.Add(pacote);
        }

        public void DeletePacote(Pacote pacote)
        {
            _context.Remove(pacote);
        }

        public async Task<Pacote> GetPacoteById(int id_pacote)
        {
            return await _context.Pacote.Where(x => x.Id_pacote == id_pacote).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Pacote>> GetPacotes()
        {
            return await _context.Pacote.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}