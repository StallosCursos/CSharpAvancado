using System;

namespace LSP___Violacao.Entitites.Suporte
{
    public class Atendimento : Processo
    {
        public string Tecnico { get; set; }

        public override void NotificarGestor() =>
           Console.WriteLine("Chico do atendimento notificado");
    }
}
