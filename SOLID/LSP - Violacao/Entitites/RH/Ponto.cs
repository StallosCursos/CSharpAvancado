using System;

namespace LSP___Violacao.Entitites.RH
{
    public class Ponto : Processo
    {
        public string Funcionario { get; set; }

        public override void NotificarGestor()
        {
            throw new NotImplementedException();
        }
    }
}
