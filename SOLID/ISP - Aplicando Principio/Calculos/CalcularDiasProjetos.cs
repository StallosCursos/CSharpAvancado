using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ISP___Aplicando_Principio.Calculos.Interfaces;
using ISP___Violacao.Entitites.Projetos;
using ISP___Violacao.Extensions;

namespace ISP___Violacao.Facade
{
    public class CalcularDiasProjetos : ICalcularDiasProjeto
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
            return tempo.DatasNoIntervalo().Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    t.DayOfWeek != DayOfWeek.Sunday &&
                    !_feriadosNacionais.Contains(t)
           ).Count();
        }
    }
}
