using System;

namespace ISP___Violacao.Entitites.RH
{
    public class Ponto : IEntidade
    {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
    }
}
