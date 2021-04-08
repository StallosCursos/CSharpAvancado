using ISP___Aplicando_Principio.Calculos.Interfaces;
using ISP___Violacao.Entitites.Suporte;
using ISP___Violacao.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ISP___Violacao.Facade
{
    public class CalcularDiasSuporte : ICalcularDiasSuporte
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
            return tempo.DatasNoIntervalo().Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    !_feriadosEstaduais.Contains(t)
           ).Count();
        }
    }
}
