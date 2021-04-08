using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DIP___Aplicando_Principio.Busca.Interfaces;

namespace DIP___Aplicando_Principio.Busca
{
    public class BuscarFeriadosNacionaisDisco : IBuscaFeriadosNacionais
    {
        public List<DateTime> BuscarFeriados()
        {
            return File.ReadLines("./feriados_nacionais.csv")
                       .Select(t => t.Split(',')[0])
                       .Select(t => DateTime.Parse(t)).ToList();
        }
    }
}
