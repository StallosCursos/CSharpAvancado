using CadastroClientesRepositorio.Repositorio.Interfaces;

namespace CadastroClientesRepositorio.Repositorio
{
    public interface IUnityOfWork
    {
        IClienteRepository clienteRepository { get; }

        void Commit();
    }
}
