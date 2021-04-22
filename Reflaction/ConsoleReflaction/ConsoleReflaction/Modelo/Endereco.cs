using ConsoleReflaction.Attributes;

namespace ConsoleReflaction.Modelo
{
    [Tabela("Endereco")]
    public class Endereco
    {
        [Coluna("Id", chave: true)]
        public int Id { get; set; }

        [Coluna("IdCliente", obrigatorio: true)]
        public int IdCliente { get; set; }

        [Coluna("Logradouro", obrigatorio: true, tamanhoMaximo: 255)]
        public string Logradouro { get; set; }

        [Coluna("Cidade", obrigatorio: true, tamanhoMaximo: 100)]
        public string Cidade { get; set; }

        [Coluna("Cep", obrigatorio: true, tamanhoMaximo: 11)]
        public string Cep { get; set; }

        [Coluna("Estado", obrigatorio: true, tamanhoMaximo: 2)]
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }
    }
}