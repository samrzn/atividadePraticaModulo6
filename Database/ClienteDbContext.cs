using atividadeAvaliativaModulo6.Model;
using Microsoft.EntityFrameworkCore;

namespace atividadeAvaliativaModulo6.Database
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            var cliente = modelBuilder.Entity<Cliente>();
            cliente.HasKey(x => x.Id);
            cliente.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            cliente.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            cliente.Property(x => x.Telefone).HasColumnName("telefone").IsRequired();
            cliente.Property(x => x.Email).HasColumnName("email").IsRequired();
            cliente.Property(x => x.Cpf).HasColumnName("cpf").IsRequired();
            cliente.Property(x => x.Senha).HasColumnName("senha").IsRequired();
            }
    }
}