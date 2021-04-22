using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleReflaction.Attributes
{
    public class ColunaAttribute: Attribute
    {
        private readonly string _nome;
        private readonly bool _chave;
        private readonly int _tamanhoMaximo;
        private readonly bool _obrigatorio;

        public ColunaAttribute(string nome, bool chave = false, int tamanhoMaximo = 0, bool obrigatorio = false)
        {
            _nome = nome;
            _chave = chave;
            _tamanhoMaximo = tamanhoMaximo;
            _obrigatorio = obrigatorio;
        }

        public string Nome => _nome;
        public bool Chave => _chave;
        public int TamnhoMaximo => _tamanhoMaximo;
        public bool Obrigatorio => _obrigatorio;
    }
}
