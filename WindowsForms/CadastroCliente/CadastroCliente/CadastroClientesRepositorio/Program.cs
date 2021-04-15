using CadastroCliente.Apresentacao;
using CadastroCliente.InfraEstrutura;
using CadastroClientesRepositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientesRepositorio
{
    static class Program
    {
        public static IUnityOfWork unityOfWork { get; private set; } = new UnitOfWork(DataContextFactory.Create());

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCadastroClienteConsulta());
        }
    }
}
