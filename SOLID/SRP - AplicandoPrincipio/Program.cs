using SRP___AplicandoPrincipio.Facade;
using SRP___AplicandoPrincipio.Manutencao;
using SRP___AplicandoPrincipio.Projetos;
using SRP___AplicandoPrincipio.Suporte;
using System;

namespace SRP___AplicandoPrincipio
{
    class Program
    {
        static void Main(string[] args)
        {
            Projeto projetox = CriarProjeto();
            Backup manutencaoProgramada = CriarBackup();
            Atendimento atendimentoX = CriarAtendimento();

            CalculoDias calculoDias = new CalculoDias();

            Console.WriteLine($"Projeto X {calculoDias.CalcularDiasProjeto(projetox)}");
            Console.WriteLine($"Backup {calculoDias.CalcularDiasManutencao(manutencaoProgramada)}");
            Console.WriteLine($"Atendimento {calculoDias.CalcularDiasSuporte(atendimentoX)}");

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
