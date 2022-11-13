using atividadeAvaliativaModulo6.Model;

namespace atividadeAvaliativaModulo6.Repository
{
    public interface IPacoteRepository
    {
        Task<IEnumerable<Pacote>> GetPacotes();
        Task<Pacote> GetPacoteById(int id_pacote);
        void AddPacote(Pacote pacote);
        void DeletePacote(Pacote pacote);
        Task<bool> SaveChangesAsync();
    }
}