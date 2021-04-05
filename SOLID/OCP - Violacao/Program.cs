using OCP___Violacao.Entitites.Manutencao;
using OCP___Violacao.Entitites.Projetos;
using OCP___Violacao.Entitites.Suporte;
using OCP___Violacao.Facade;
using System;

namespace OCP___Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Projeto projetox = CriarProjeto();
            Backup manutencaoProgramada = CriarBackup();
            Atendimento atendimentoX = CriarAtendimento();

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
    }
}
