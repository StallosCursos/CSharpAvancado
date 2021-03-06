using OCP___AplicandoPrincipio.Entitites.Manutencao;
using OCP___AplicandoPrincipio.Entitites.Projetos;
using OCP___AplicandoPrincipio.Entitites.Suporte;

namespace OCP___AplicandoPrincipio.Facade
{
    public class CalcularDiasFacade
    {
        public int CalcularDiasManutencao(Backup backup) => new CalcularDiasManutencao().Calcular(backup);
        public int CalcularDiasProjeto(Projeto projeto) => new CalcularDiasProjetos().Calcular(projeto);
        public int CalcularDiasAtendimento(Atendimento atendimento) => new CalcularDiasSuporte().Calcular(atendimento);
    }
}
