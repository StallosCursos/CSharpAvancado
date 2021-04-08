using DIP___Aplicando_Principio.Calculos.Interfaces;
using DIP___Aplicando_Principio.Entitites.RH;

namespace DIP___Aplicando_Principio.Calculos
{
    public class CalcularHorasPonto : ICalcularHorasPonto
    {
        public int CalcularHoras(Ponto tempo) =>
            (tempo.DataSaida - tempo.DataEntrada).Hours;

        public int CalcularHorasExtras(Ponto tempo) =>
            CalcularHoras(tempo) - 8;
    }
}
