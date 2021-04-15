namespace CadastroCliente.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }
    }
}