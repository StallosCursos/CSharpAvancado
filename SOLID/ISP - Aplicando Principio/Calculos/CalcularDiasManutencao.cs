using ISP___Aplicando_Principio.Calculos.Interfaces;
using ISP___Violacao.Entitites.Manutencao;

namespace ISP___Violacao.Facade
{
    public class CalcularDiasManutencao : ICalcularDiasManutencao
    {
        public int Calcular(Backup tempo) =>
            (tempo.DataFim - tempo.DataInicio).Days;
    }
}
