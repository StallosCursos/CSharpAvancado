using SRP___AplicandoPrincipio.Manutencao;
using SRP___AplicandoPrincipio.Projetos;
using SRP___AplicandoPrincipio.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SRP___AplicandoPrincipio
{
    public class CalculoDias
    {
        public int CalcularDiasManutencao(Backup backup) 
        {
           return (backup.DataFim - backup.DataInicio).Days;
        }

        public int CalcularDiasProjeto(Projeto projeto)
        {
            return DatasNoIntervalo(projeto).Where(
                t => t.DayOfWeek != DayOfWeek.Saturday && t.DayOfWeek != DayOfWeek.Sunday
            ).Count();
        }

        public int CalcularDiasSuporte(Atendimento atendimento)
        {
            return DatasNoIntervalo(atendimento).Where(t => t.DayOfWeek != DayOfWeek.Saturday).Count();
        }

        private IEnumerable<DateTime> DatasNoIntervalo(ITempoExecucao tempoExecucao)
        {
            var diasCorridos = (tempoExecucao.DataFim - tempoExecucao.DataInicio).Days;
            var datas = Enumerable.Range(0, diasCorridos)
                                  .Select(t => tempoExecucao.DataInicio.AddDays(t));
            return datas;
        }
    }
}
