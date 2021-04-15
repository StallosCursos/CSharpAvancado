using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCliente.Model
{
    public class Cliente
    {
        public Cliente()
        {
            this.Endereco = new List<Endereco>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Endereco> Endereco { get; set; }
    }
}
