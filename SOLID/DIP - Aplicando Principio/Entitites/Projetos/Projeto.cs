using System;

namespace DIP___Aplicando_Principio.Entitites.Projetos
{
    public class Projeto : Processo
    {
        public string Nome { get; set; }

        public override void NotificarGestor() =>
          Console.WriteLine("Zé do projeto notificado");
    }
}
