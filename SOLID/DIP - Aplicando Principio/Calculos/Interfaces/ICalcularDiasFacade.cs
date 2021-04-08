using DIP___Aplicando_Principio.Calculos.Interfaces;

namespace DIP___Aplicando_Principio.Calculos
{
    public interface ICalcularDiasFacade
    {
        ICalcularDiasSuporte CalcularDiasAtendimento { get; }
        ICalcularDiasManutencao CalcularDiasManutencao { get; }
        ICalcularDiasProjeto CalcularDiasProjeto { get; }
        ICalcularHorasPonto CalcularHorasPonto { get; }
    }
}