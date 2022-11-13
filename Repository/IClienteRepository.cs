using atividadeAvaliativaModulo6.Model;

namespace atividadeAvaliativaModulo6.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetClienteById(int id_cliente);
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(Cliente cliente);
        Task<bool> SaveChangesAsync();
    }
}