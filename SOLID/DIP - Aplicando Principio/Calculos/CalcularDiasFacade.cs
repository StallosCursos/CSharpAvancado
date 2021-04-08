using DIP___Aplicando_Principio.Calculos.Interfaces;

namespace DIP___Aplicando_Principio.Calculos
{
    public class CalcularDiasFacade : ICalcularDiasFacade
    {
        private readonly ICalcularDiasManutencao _calcularDiadManutencao;
        private readonly ICalcularDiasProjeto _calcularDiasProjeto;
        private readonly ICalcularDiasSuporte _calcularDiasSuporte;
        private readonly ICalcularHorasPonto _calcularHorasPonto;

        public CalcularDiasFacade
        (
           ICalcularDiasManutencao calcularDiasManutencao,
           ICalcularDiasProjeto calcularDiasProjeto,
           ICalcularDiasSuporte calcularDiasSuporte,
           ICalcularHorasPonto calcularHorasPonto
        )
        {
            _calcularDiadManutencao = calcularDiasManutencao;
            _calcularDiasProjeto = calcularDiasProjeto;
            _calcularDiasSuporte = calcularDiasSuporte;
            _calcularHorasPonto = calcularHorasPonto;
        }

        public ICalcularDiasManutencao CalcularDiasManutencao =>_calcularDiadManutencao;
        public ICalcularDiasProjeto CalcularDiasProjeto => _calcularDiasProjeto;
        public ICalcularDiasSuporte CalcularDiasAtendimento => _calcularDiasSuporte;
        public ICalcularHorasPonto CalcularHorasPonto => _calcularHorasPonto;
    }
}
