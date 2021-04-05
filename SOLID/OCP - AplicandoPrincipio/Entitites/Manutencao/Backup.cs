using OCP___Violacao.Entitites;
using System;

namespace OCP___AplicandoPrincipio.Entitites.Manutencao
{
    public class Backup : ITempoExecucao
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
