using LSP___Violacao.Entitites.Manutencao;
using LSP___Violacao.Entitites.Projetos;
using LSP___Violacao.Entitites.Suporte;

namespace LSP___Violacao.Facade
{
    public class CalcularDiasFacade
    {
        public int CalcularDiasManutencao(Backup backup) => new CalcularDiasManutencao().Calcular(backup);
        public int CalcularDiasProjeto(Projeto projeto) => new CalcularDiasProjetos().Calcular(projeto);
        public int CalcularDiasAtendimento(Atendimento atendimento) => new CalcularDiasSuporte().Calcular(atendimento);
    }
}
