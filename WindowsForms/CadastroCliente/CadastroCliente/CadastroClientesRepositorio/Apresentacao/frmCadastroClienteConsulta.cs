using System;
using System.Windows.Forms;
using CadastroCliente.InfraEstrutura;
using CadastroClientesRepositorio;

namespace CadastroCliente.Apresentacao
{
    public partial class frmCadastroClienteConsulta : Form
    {
        public frmCadastroClienteConsulta()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (ClienteDataContext clienteDataContext = DataContextFactory.Create())
            {
                var clientes = string.IsNullOrEmpty(txtNomeCliente.Text) ? 
                        Program.unityOfWork.clienteRepository.Clientes() : 
                        Program.unityOfWork.clienteRepository.BuscarClientesPorNome(txtNomeCliente.Text); 

                dtgClientes.DataSource = clientes;
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }
    }
}
