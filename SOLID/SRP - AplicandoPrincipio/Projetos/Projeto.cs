using System;
using System.Collections.Generic;
using System.Text;

namespace SRP___AplicandoPrincipio.Projetos
{
    public class Projeto : ITempoExecucao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
