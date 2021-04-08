using System;
using System.Linq;
using DIP___Aplicando_Principio.Busca.Interfaces;
using DIP___Aplicando_Principio.Calculos.Interfaces;
using DIP___Aplicando_Principio.Entitites.Projetos;
using DIP___Aplicando_Principio.Extensions;

namespace DIP___Aplicando_Principio.Calculos
{
    public class CalcularDiasProjetos : ICalcularDiasProjeto
    {
        private readonly IBuscaFeriadosNacionais _buscaFeriadosNacionais;

        public CalcularDiasProjetos(IBuscaFeriadosNacionais buscaFeriadosNacionais) =>
           _buscaFeriadosNacionais = buscaFeriadosNacionais;

        public int Calcular(Projeto tempo)
        {
            return tempo.DatasNoIntervalo().Where(
               t => t.DayOfWeek != DayOfWeek.Saturday &&
                    t.DayOfWeek != DayOfWeek.Sunday &&
                    !_buscaFeriadosNacionais.BuscarFeriados().Contains(t)
           ).Count();
        }
    }
}
