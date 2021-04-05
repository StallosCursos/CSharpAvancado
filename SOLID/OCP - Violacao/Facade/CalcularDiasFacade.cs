using OCP___Violacao.Entitites.Manutencao;
using OCP___Violacao.Entitites.Projetos;
using OCP___Violacao.Entitites.Suporte;

namespace OCP___Violacao.Facade
{
    public class CalcularDiasFacade
    {
        public int CalcularDiasManutencao(Backup backup) => new CalcularDiasManutencao().Calcular(backup);
        public int CalcularDiasProjeto(Projeto projeto) => new CalcularDiasProjetos().Calcular(projeto);
        public int CalcularDiasAtendimento(Atendimento atendimento) => new CalcularDiasSuporte().Calcular(atendimento);
    }
}
