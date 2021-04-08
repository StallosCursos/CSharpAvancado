using ISP___Aplicando_Principio.Calculos.Interfaces;

namespace ISP___Violacao.Facade
{
    public class CalcularDiasFacade
    {
        public ICalcularDiasManutencao CalcularDiasManutencao => new CalcularDiasManutencao();
        public ICalcularDiasProjeto CalcularDiasProjeto => new CalcularDiasProjetos();
        public ICalcularDiasSuporte CalcularDiasAtendimento => new CalcularDiasSuporte();
        public ICalcularHorasPonto CalcularHorasPonto => new CalcularHorasPonto();
    }
}
