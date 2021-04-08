using ISP___Violacao.Entitites.RH;

namespace ISP___Violacao.Facade
{
    public class CalcularHorasPonto : ICalcularDias<Ponto>
    {
        public int Calcular(Ponto tempo)
        {
            throw new System.NotImplementedException();
        }

        public int CalcularHoras(Ponto tempo) => 
            (tempo.DataSaida - tempo.DataEntrada).Hours;

        public int CalcularHorasExtras(Ponto tempo) => 
            CalcularHoras(tempo) - 8;
    }
}
