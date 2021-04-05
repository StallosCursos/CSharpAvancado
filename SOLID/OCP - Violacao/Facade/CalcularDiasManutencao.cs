using OCP___Violacao.Entitites.Manutencao;

namespace OCP___Violacao.Facade
{
    public class CalcularDiasManutencao : ICalcularDias<Backup>
    {
        public int Calcular(Backup tempo) =>
            (tempo.DataFim - tempo.DataInicio).Days;
    }
}
