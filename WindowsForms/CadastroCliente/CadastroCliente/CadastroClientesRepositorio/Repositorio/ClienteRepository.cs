using System.Collections.Generic;
using System.Linq;
using CadastroCliente.InfraEstrutura;
using CadastroCliente.Model;
using CadastroClientesRepositorio.Repositorio.Interfaces;

namespace CadastroClientesRepositorio.Repositorio
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IClienteDataContext _clienteDataContext;

        public ClienteRepository(IClienteDataContext clienteDataContext) =>
            _clienteDataContext = clienteDataContext;

        public void AtualizarCliente(Cliente cliente) => _clienteDataContext.Clientes.Update(cliente);

        public Cliente BuscarClientePorChave(int Id) => _clienteDataContext.Clientes.Find(Id);

        public List<Cliente> Clientes() => _clienteDataContext.Clientes.ToList();

        public void InserirCliente(Cliente cliente) => _clienteDataContext.Clientes.Add(cliente);

        public void RemoverCliente(Cliente cliente) => _clienteDataContext.Clientes.Remove(cliente);

        public List<Cliente> BuscarClientesPorNome(string Nome)
        {
            return _clienteDataContext.Clientes.Where(t => t.Nome.StartsWith(Nome))
                                               .ToList();
        }

    }
}
