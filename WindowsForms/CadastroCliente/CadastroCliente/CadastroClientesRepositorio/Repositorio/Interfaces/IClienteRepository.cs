using CadastroCliente.Model;
using System.Collections.Generic;

namespace CadastroClientesRepositorio.Repositorio.Interfaces
{
    public interface IClienteRepository
    {
        void InserirCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void RemoverCliente(Cliente cliente);

        List<Cliente> Clientes();
        Cliente BuscarClientePorChave(int Id);
        List<Cliente> BuscarClientesPorNome(string Nome);
    }
}
