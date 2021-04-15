using CadastroCliente.InfraEstrutura;
using CadastroClientesRepositorio.Repositorio.Interfaces;

namespace CadastroClientesRepositorio.Repositorio
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly IClienteDataContext _clienteDataContext;

        public UnitOfWork(IClienteDataContext clienteDataContext) =>
            _clienteDataContext = clienteDataContext;

        public IClienteRepository clienteRepository => 
            new ClienteRepository(_clienteDataContext);

        public void Commit() => _clienteDataContext.SaveChanges();
    }
}
