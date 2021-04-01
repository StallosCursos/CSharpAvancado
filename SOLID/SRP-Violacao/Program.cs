using SRP_Violacao.Manutencao;
using SRP_Violacao.Suporte;
using System;

namespace SRP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Projeto projetox = CriarProjeto();
            Backup manutencaoProgramada = CriarBackup();
            Atendimento atendimentoX = CriarAtendimento();

            CalculoDias calculoDias = new CalculoDias();

            Console.WriteLine($"Projeto X {calculoDias.ApurarDias(projetox)}");
            Console.WriteLine($"Backup {calculoDias.ApurarDias(manutencaoProgramada)}");
            Console.WriteLine($"Atendimento {calculoDias.ApurarDias(atendimentoX)}");
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
