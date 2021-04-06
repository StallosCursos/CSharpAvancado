using System;
using System.Collections.Generic;
using System.Text;

namespace LSP___Violacao.Entitites.Projetos
{
    public class Projeto : Processo
    {
        public string Nome { get; set; }

        public override void NotificarGestor() =>
          Console.WriteLine("Zé do projeto notificado");
    }
}
