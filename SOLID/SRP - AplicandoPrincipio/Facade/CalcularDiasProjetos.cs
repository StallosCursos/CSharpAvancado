using SRP___AplicandoPrincipio.Projetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SRP___AplicandoPrincipio.Facade
{
    public class CalcularDiasProjetos : ICalcularDias<Projeto>
    {
        private readonly List<DateTime> _feriadosNacionais;

        public CalcularDiasProjetos()
        {
            _feriadosNacionais = File.ReadLines("./feriados_nacionais.csv")
                                     .Select(t => t.Split(',')[0])
                                     .Select(t => DateTime.Parse(t)).ToList();
        }

        public int Calcular(Projeto tempo)
        {
            return DatasNoIntervalo(tempo).Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    t.DayOfWeek != DayOfWeek.Sunday && 
                    !_feriadosNacionais.Contains(t)
           ).Count();
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
