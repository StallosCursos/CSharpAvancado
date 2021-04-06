using System;

namespace LSP___Violacao.Entitites.Manutencao
{
    public class Backup : Processo
    {
        public string Usuario { get; set; }

        public override void NotificarGestor() => 
            Console.WriteLine("João do backup notificado");
    }
}
