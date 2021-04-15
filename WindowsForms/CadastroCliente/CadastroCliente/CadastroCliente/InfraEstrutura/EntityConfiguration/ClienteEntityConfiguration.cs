using CadastroCliente.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroCliente.InfraEstrutura.EntityConfiguration
{
    public class ClienteEntityConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome).IsRequired();

            builder.HasMany(t => t.Endereco).WithOne(t => t.Cliente).HasForeignKey(t => t.IdCliente);
        }
    }
}
