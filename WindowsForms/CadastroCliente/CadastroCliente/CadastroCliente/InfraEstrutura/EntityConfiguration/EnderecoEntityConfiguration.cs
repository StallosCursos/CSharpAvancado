using CadastroCliente.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroCliente.InfraEstrutura.EntityConfiguration
{
    public class EnderecoEntityConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.IdCliente).IsRequired();
            builder.Property(t => t.Logradouro).IsRequired();
            builder.Property(t => t.Cidade).IsRequired();
            builder.Property(t => t.Cep).IsRequired();

            builder.HasOne(t => t.Cliente).WithMany(t => t.Endereco).HasForeignKey(t => t.IdCliente);
        }
    }
}
