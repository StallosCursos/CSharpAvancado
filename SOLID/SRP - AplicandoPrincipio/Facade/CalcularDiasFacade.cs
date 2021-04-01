using SRP___AplicandoPrincipio.Manutencao;
using SRP___AplicandoPrincipio.Projetos;
using SRP___AplicandoPrincipio.Suporte;

namespace SRP___AplicandoPrincipio.Facade
{
    public class CalcularDiasFacade
    {
        public int CalcularDiasManutencao(Backup backup) => new CalcularDiasManutencao().Calcular(backup);
        public int CalcularDiasProjeto(Projeto projeto) => new CalcularDiasProjetos().Calcular(projeto);
        public int CalcularDiasAtendimento(Atendimento atendimento) => new CalcularDiasSuporte().Calcular(atendimento);
    }
}
