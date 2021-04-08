namespace ISP___Violacao.Facade
{
    public interface ICalcularDias<TTempo> where TTempo : class
    {
        int Calcular(TTempo tempo);
        int CalcularHoras(TTempo tempo);
        int CalcularHorasExtras(TTempo tempo);
    }
}
