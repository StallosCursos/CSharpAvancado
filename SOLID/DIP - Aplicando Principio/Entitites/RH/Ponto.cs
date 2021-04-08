using System;

namespace DIP___Aplicando_Principio.Entitites.RH
{
    public class Ponto : IEntidade
    {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
    }
}
