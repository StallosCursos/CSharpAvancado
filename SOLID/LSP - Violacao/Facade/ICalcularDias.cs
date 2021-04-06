using LSP___Violacao.Entitites;

namespace LSP___Violacao.Facade
{
    public interface ICalcularDias<TTempo> where TTempo : ITempoExecucao
    {
        int Calcular(TTempo tempo);
    }
}
