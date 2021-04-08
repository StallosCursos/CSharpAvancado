using ISP___Violacao.Entitites.Manutencao;
using ISP___Violacao.Entitites.Projetos;
using ISP___Violacao.Entitites.RH;
using ISP___Violacao.Entitites.Suporte;

namespace ISP___Violacao.Facade
{
    public class CalcularDiasFacade
    {
        public int CalcularDiasManutencao(Backup backup) => new CalcularDiasManutencao().Calcular(backup);
        public int CalcularDiasProjeto(Projeto projeto) => new CalcularDiasProjetos().Calcular(projeto);
        public int CalcularDiasAtendimento(Atendimento atendimento) => new CalcularDiasSuporte().Calcular(atendimento);
        public int CalcularHorasTrabalhadasFuncionario(Ponto ponto) => new CalcularHorasPonto().CalcularHoras(ponto);
        public int CalcularHorasExtras(Ponto ponto) => new CalcularHorasPonto().CalcularHorasExtras(ponto);
    }
}
