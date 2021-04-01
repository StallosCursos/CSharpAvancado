using System;

namespace SRP___AplicandoPrincipio
{
    public interface ITempoExecucao
    {
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
    }
}