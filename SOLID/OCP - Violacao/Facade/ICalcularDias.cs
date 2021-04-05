using OCP___Violacao.Entitites;

namespace OCP___Violacao.Facade
{
    public interface ICalcularDias<TTempo> where TTempo : ITempoExecucao
    {
        int Calcular(TTempo tempo);
    }
}
