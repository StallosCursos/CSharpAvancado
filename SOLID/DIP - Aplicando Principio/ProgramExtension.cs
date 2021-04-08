using DIP___Aplicando_Principio.Busca;
using DIP___Aplicando_Principio.Busca.Interfaces;
using DIP___Aplicando_Principio.Calculos;
using DIP___Aplicando_Principio.Calculos.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DIP___Aplicando_Principio
{
    public static class IOCContainer
    {
        private static readonly ServiceCollection _serviceDescriptors = new ServiceCollection();
        private static ServiceProvider _serviceProvider;

        public static TService Service<TService>() where TService : class =>
            _serviceProvider.GetService<TService>();

        public static void ConfigureDIP()
        {
            ConfigureCalculos();
            ConfigureBusca();

            _serviceProvider = _serviceDescriptors.BuildServiceProvider();
        }

        private static void ConfigureBusca()
        {
            _serviceDescriptors.AddTransient<IBuscaFeriadosEstaduais, BuscaFeriadosEstaduaisDisco>();
            _serviceDescriptors.AddTransient<IBuscaFeriadosNacionais, BuscarFeriadosNacionaisDisco>();
        }

        private static void ConfigureCalculos()
        {
            _serviceDescriptors.AddTransient<ICalcularDiasManutencao, CalcularDiasManutencao>();
            _serviceDescriptors.AddTransient<ICalcularDiasProjeto, CalcularDiasProjetos>();
            _serviceDescriptors.AddTransient<ICalcularDiasSuporte, CalcularDiasSuporte>();
            _serviceDescriptors.AddTransient<ICalcularHorasPonto, CalcularHorasPonto>();
            _serviceDescriptors.AddTransient<ICalcularDiasFacade, CalcularDiasFacade>();
        }
    }
}
