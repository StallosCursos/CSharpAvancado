using DIP___Aplicando_Principio.Entitites.RH;

namespace DIP___Aplicando_Principio.Calculos.Interfaces
{
    public interface ICalcularHorasPonto
    {
        int CalcularHoras(Ponto tempo);
        int CalcularHorasExtras(Ponto tempo);
    }
}
