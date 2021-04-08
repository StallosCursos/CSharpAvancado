using ISP___Violacao.Entitites;

namespace ISP___Aplicando_Principio.Calculos.Interfaces
{
    public interface ICalcularDias<TTempo> where TTempo : ITempoExecucao
    {
        int Calcular(TTempo tempo);
    }
}
