using System;

namespace ConsoleReflaction.Attributes
{
    public class TabelaAttribute: Attribute
    {
        private string _nomeTabela;

        public TabelaAttribute(string nome) =>
            _nomeTabela = nome;

        public string Nome => _nomeTabela;
    }
}
