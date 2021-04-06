using LSP___Violacao.Entitites;

namespace LSP___Violacao.Facade
{
    public interface ICalcularDias<TTempo> where TTempo : ITempoRegistrado
    {
        int Calcular(TTempo tempo);
    }
}
