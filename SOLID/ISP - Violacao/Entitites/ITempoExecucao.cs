using System;

namespace ISP___Violacao.Entitites
{
    public interface ITempoExecucao
    {
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
    }
}