using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DIP___Aplicando_Principio.Busca.Interfaces;

namespace DIP___Aplicando_Principio.Busca
{
    public class BuscaFeriadosEstaduaisDisco : IBuscaFeriadosEstaduais
    {
        private readonly string _estado;

        public BuscaFeriadosEstaduaisDisco() => _estado = "SP";

        public List<DateTime> BuscarFeriados()
        {
            return File.ReadLines("./feriados_estaduais.csv")
                       .Where(t => t.Split(',')[4] == _estado)
                       .Select(t => t.Split(',')[0])
                       .Select(t => DateTime.Parse(t))
                       .ToList();
        }
    }
}
