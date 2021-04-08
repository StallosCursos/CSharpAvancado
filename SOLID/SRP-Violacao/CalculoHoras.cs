using SRP_Violacao.Manutencao;
using SRP_Violacao.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRP_Violacao
{
    public class CalculoDias
    {
        // Metodo unico para calcular dias executados pelo tempo
        /*public int ApurarDias(ITempoExecucao tempoExecucao)
        {
            return (tempoExecucao.DataFim - tempoExecucao.DataInicio).Days;
        }*/

        public int ApurarDias(ITempoExecucao tempoExecucao)
        {
            int dias = 0;

            if (tempoExecucao.GetType() == typeof(Backup))
            {
                dias = (tempoExecucao.DataFim - tempoExecucao.DataInicio).Days;
            }
            else if (tempoExecucao.GetType() == typeof(Projeto))
            {
                var diasCorridos = (tempoExecucao.DataFim - tempoExecucao.DataInicio).Days;
                var datas = Enumerable.Range(0, diasCorridos)
                                      .Select(t => tempoExecucao.DataInicio.AddDays(t));

                dias = datas.Where(t => t.DayOfWeek != DayOfWeek.Saturday && t.DayOfWeek != DayOfWeek.Sunday).Count();
            }
            else if (tempoExecucao.GetType() == typeof(Atendimento))
            {
                var diasCorridos = (tempoExecucao.DataFim - tempoExecucao.DataInicio).Days;
                var datas = Enumerable.Range(0, diasCorridos)
                                      .Select(t => tempoExecucao.DataInicio.AddDays(t));

                dias = datas.Where(t => t.DayOfWeek != DayOfWeek.Sunday).Count();
            }

            return dias;
        }
    }
}
