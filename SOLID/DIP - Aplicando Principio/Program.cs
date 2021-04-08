using DIP___Aplicando_Principio.Calculos;
using DIP___Aplicando_Principio.Entitites.Manutencao;
using DIP___Aplicando_Principio.Entitites.Projetos;
using DIP___Aplicando_Principio.Entitites.RH;
using DIP___Aplicando_Principio.Entitites.Suporte;
using System;

namespace DIP___Aplicando_Principio
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOCContainer.ConfigureDIP();

            Projeto projetox = CriarProjeto();
            Backup manutencaoProgramada = CriarBackup();
            Atendimento atendimentoX = CriarAtendimento();
            Ponto PontoFuncionario = CriarPonto();

            ICalcularDiasFacade calcularDiasFacade = IOCContainer.Service<ICalcularDiasFacade>();

            Console.WriteLine($"Projeto X {calcularDiasFacade.CalcularDiasProjeto.Calcular(projetox)}");
            Console.WriteLine($"Backup {calcularDiasFacade.CalcularDiasManutencao.Calcular(manutencaoProgramada)}");
            Console.WriteLine($"Atendimento {calcularDiasFacade.CalcularDiasAtendimento.Calcular(atendimentoX)}");
            Console.WriteLine($@"Funcionario {PontoFuncionario.Funcionario} Trabalhou {calcularDiasFacade.CalcularHorasPonto.CalcularHoras(PontoFuncionario) }h Horas Extras {calcularDiasFacade.CalcularHorasPonto.CalcularHorasExtras(PontoFuncionario) }h");
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
