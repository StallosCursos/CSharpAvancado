using LSP___Violacao.Entitites.Manutencao;

namespace LSP___Violacao.Facade
{
    public class CalcularDiasManutencao : ICalcularDias<Backup>
    {
        public int Calcular(Backup tempo) =>
            (tempo.DataFim - tempo.DataInicio).Days;
    }
}
