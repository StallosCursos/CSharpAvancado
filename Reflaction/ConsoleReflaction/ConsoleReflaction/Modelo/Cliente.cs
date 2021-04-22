using ConsoleReflaction.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleReflaction.Modelo
{
    [Tabela("Clientes")]
    public class Cliente
    {
        public Cliente()
        {
            Endereco = new List<Endereco>();
        }

        [Coluna("Id", chave: true)]
        public int Id { get; set; }

        [Coluna("Nome", tamanhoMaximo: 255, obrigatorio: true)]
        public string Nome { get; set; }

        public List<Endereco> Endereco { get; set; }
    }
}
