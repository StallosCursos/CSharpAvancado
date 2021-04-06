using System;
using System.Collections.Generic;
using System.Linq;
using LSP___Violacao.Entitites;

namespace LSP___Violacao.Extensions
{
    public static class ITempoExecucaoExtension
    {
        public static IEnumerable<DateTime> DatasNoIntervalo(this ITempoExecucao tempoExecucao)
        {
            var diasCorridos = (tempoExecucao.DataFim - tempoExecucao.DataInicio).Days;
            var datas = Enumerable.Range(0, diasCorridos)
                                  .Select(t => tempoExecucao.DataInicio.AddDays(t));
            return datas;
        }
    }
}
