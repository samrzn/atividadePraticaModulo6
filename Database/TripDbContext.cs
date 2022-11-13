using atividadeAvaliativaModulo6.Model;
using Microsoft.EntityFrameworkCore;

namespace atividadeAvaliativaModulo6.Database
{
    public class TripDbContext : DbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Pacote> Pacote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cliente = modelBuilder.Entity<Cliente>();
            cliente.HasKey(x => x.Id_cliente);
            cliente.Property(x => x.Id_cliente).HasColumnName("id_cliente").ValueGeneratedOnAdd();
            cliente.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            cliente.Property(x => x.Telefone).HasColumnName("telefone").IsRequired();
            cliente.Property(x => x.Email).HasColumnName("email").IsRequired();
            cliente.Property(x => x.Cpf).HasColumnName("cpf").IsRequired();
            cliente.Property(x => x.Senha).HasColumnName("senha").IsRequired();

            var pacote = modelBuilder.Entity<Pacote>();
            pacote.HasKey(x => x.Id_pacote);
            pacote.Property(x => x.Id_pacote).HasColumnName("id_pacote").ValueGeneratedOnAdd();
            pacote.Property(x => x.Destino).HasColumnName("destino").IsRequired();
            pacote.Property(x => x.Valor).HasColumnName("valor").IsRequired();
            pacote.Property(x => x.Data_viagem).HasColumnName("data_viagem").IsRequired();

        }
    }
}