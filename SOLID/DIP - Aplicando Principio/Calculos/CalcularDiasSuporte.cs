using System;
using System.Linq;
using DIP___Aplicando_Principio.Busca.Interfaces;
using DIP___Aplicando_Principio.Calculos.Interfaces;
using DIP___Aplicando_Principio.Entitites.Suporte;
using DIP___Aplicando_Principio.Extensions;

namespace DIP___Aplicando_Principio.Calculos
{
    public class CalcularDiasSuporte : ICalcularDiasSuporte
    {
        private IBuscaFeriadosEstaduais _buscaFeriadosEstaduais;

        public CalcularDiasSuporte(IBuscaFeriadosEstaduais buscaFeriadosEstaduais) =>
            _buscaFeriadosEstaduais = buscaFeriadosEstaduais;
        

        public int Calcular(Atendimento tempo)
        {
            return tempo.DatasNoIntervalo().Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    !_buscaFeriadosEstaduais.BuscarFeriados().Contains(t)
           ).Count();
        }
    }
}
