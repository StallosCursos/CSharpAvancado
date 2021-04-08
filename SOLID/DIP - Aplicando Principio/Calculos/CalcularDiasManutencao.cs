using DIP___Aplicando_Principio.Calculos.Interfaces;
using DIP___Aplicando_Principio.Entitites.Manutencao;

namespace DIP___Aplicando_Principio.Calculos
{
    public class CalcularDiasManutencao : ICalcularDiasManutencao
    {
        public int Calcular(Backup tempo) =>
            (tempo.DataFim - tempo.DataInicio).Days;
    }
}
