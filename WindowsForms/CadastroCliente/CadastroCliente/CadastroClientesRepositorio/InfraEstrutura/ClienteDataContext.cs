using CadastroCliente.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente.InfraEstrutura
{
    public class ClienteDataContext : DbContext, IClienteDataContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public ClienteDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
