using CadastroCliente.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CadastroCliente.InfraEstrutura
{
    public interface IClienteDataContext: IDisposable
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Endereco> Enderecos { get; set; }

        int SaveChanges();

    }
}
