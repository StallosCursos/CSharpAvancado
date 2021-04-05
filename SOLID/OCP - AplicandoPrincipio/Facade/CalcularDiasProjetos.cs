using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OCP___AplicandoPrincipio.Entitites.Projetos;
using OCP___AplicandoPrincipio.Extensions;

namespace OCP___AplicandoPrincipio.Facade
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
            return tempo.DatasNoIntervalo().Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    t.DayOfWeek != DayOfWeek.Sunday &&
                    !_feriadosNacionais.Contains(t)
           ).Count();
        }
    }
}
