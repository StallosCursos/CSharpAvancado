using System;

namespace OCP___Violacao.Entitites.Suporte
{
    public class Atendimento : ITempoExecucao
    {
        public int Id { get; set; }
        public string Tecnico { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
