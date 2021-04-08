using System;

namespace DIP___Aplicando_Principio.Entitites
{
    public interface ITempoExecucao
    {
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
    }
}