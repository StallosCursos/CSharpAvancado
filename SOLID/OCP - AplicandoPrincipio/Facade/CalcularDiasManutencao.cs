using OCP___AplicandoPrincipio.Entitites.Manutencao;

namespace OCP___AplicandoPrincipio.Facade
{
    public class CalcularDiasManutencao : ICalcularDias<Backup>
    {
        public int Calcular(Backup tempo) =>
            (tempo.DataFim - tempo.DataInicio).Days;
    }
}
