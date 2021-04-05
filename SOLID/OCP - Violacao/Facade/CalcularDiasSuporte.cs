using OCP___Violacao.Entitites;
using OCP___Violacao.Entitites.Suporte;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OCP___Violacao.Facade
{
    public class CalcularDiasSuporte : ICalcularDias<Atendimento>
    {
        private readonly string _estado;
        private readonly List<DateTime> _feriadosEstaduais;

        public CalcularDiasSuporte()
        {
            _estado = "SP";
            _feriadosEstaduais = File.ReadLines("./feriados_estaduais.csv")
                                     .Where(t => t.Split(',')[4] == _estado)
                                     .Select(t => t.Split(',')[0])
                                     .Select(t => DateTime.Parse(t))
                                     .ToList();
        }

        public int Calcular(Atendimento tempo)
        {
            return DatasNoIntervalo(tempo).Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    !_feriadosEstaduais.Contains(t)
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
