using LSP___Violacao.Entitites.Manutencao;
using LSP___Violacao.Entitites.Projetos;
using LSP___Violacao.Entitites.RH;
using LSP___Violacao.Entitites.Suporte;
using LSP___Violacao.Facade;
using System;

namespace OCP___AplicandoPrincipio
{
    class Program
    {
        static void Main(string[] args)
        {
            Projeto projetox = CriarProjeto();
            Backup manutencaoProgramada = CriarBackup();
            Atendimento atendimentoX = CriarAtendimento();
            Ponto PontoFuncionario = CriarPonto();

            CalcularDiasFacade calcularDiasFacade = new CalcularDiasFacade();

            Console.WriteLine($"Projeto X {calcularDiasFacade.CalcularDiasProjeto(projetox)}");
            Console.WriteLine($"Backup {calcularDiasFacade.CalcularDiasManutencao(manutencaoProgramada)}");
            Console.WriteLine($"Atendimento {calcularDiasFacade.CalcularDiasAtendimento(atendimentoX)}");
        }

        private static Atendimento CriarAtendimento()
        {
            return new Atendimento
            {
                Id = 1,
                Tecnico = "Ze",
                DataInicio = DateTime.Parse("01/03/2021 08:30:00"),
                DataFim = DateTime.Parse("27/06/2021 18:00:00")
            };
        }

        private static Backup CriarBackup()
        {
            return new Backup
            {
                Id = 1,
                Usuario = "Chico",
                DataInicio = DateTime.Parse("01/03/2021 08:30:00"),
                DataFim = DateTime.Parse("27/06/2021 18:00:00")
            };
        }

        private static Projeto CriarProjeto()
        {
            return new Projeto
            {
                Id = 1,
                Nome = "Projeto X",
                DataInicio = DateTime.Parse("01/03/2021 08:30:00"),
                DataFim = DateTime.Parse("27/06/2021 18:00:00")
            };
        }

        private static Ponto CriarPonto()
        {
            return new Ponto
            {
                Id = 1,
                Funcionario = "Ze Funcionario",
                DataEntrada = DateTime.Parse("01/03/2021 08:30:00"),
                DataSaida = DateTime.Parse("27/06/2021 18:00:00")
            };
        }
    }
}
