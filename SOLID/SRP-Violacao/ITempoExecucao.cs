using System;

namespace SRP_Violacao
{
    public interface ITempoExecucao
    {
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
    }
}