namespace SRP___AplicandoPrincipio.Facade
{
    public interface ICalcularDias<TTempo> where TTempo: ITempoExecucao
    {
        int Calcular(TTempo tempo);
    }
}
