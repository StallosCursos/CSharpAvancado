using DIP___Aplicando_Principio.Entitites;

namespace DIP___Aplicando_Principio.Calculos.Interfaces
{
    public interface ICalcularDias<TTempo> where TTempo : ITempoExecucao
    {
        int Calcular(TTempo tempo);
    }
}
