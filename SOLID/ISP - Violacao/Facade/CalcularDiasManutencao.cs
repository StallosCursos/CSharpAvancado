using ISP___Violacao.Entitites.Manutencao;

namespace ISP___Violacao.Facade
{
    public class CalcularDiasManutencao : ICalcularDias<Backup>
    {
        public int Calcular(Backup tempo) =>
            (tempo.DataFim - tempo.DataInicio).Days;

        public int CalcularHoras(Backup tempo)
        {
            throw new System.NotImplementedException();
        }

        public int CalcularHorasExtras(Backup tempo)
        {
            throw new System.NotImplementedException();
        }
    }
}
