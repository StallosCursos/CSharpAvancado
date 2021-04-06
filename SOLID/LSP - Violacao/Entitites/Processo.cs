using System;

namespace LSP___Violacao.Entitites
{
    public abstract class Processo : ITempoExecucao, IEntidade
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Processo() => NotificarGestor();

        public abstract void NotificarGestor();
    }
}
