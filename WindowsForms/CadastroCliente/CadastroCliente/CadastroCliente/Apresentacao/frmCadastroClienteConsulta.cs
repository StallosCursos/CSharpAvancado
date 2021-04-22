using CadastroCliente.InfraEstrutura;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                        clienteDataContext.Clientes : 
                        clienteDataContext.Clientes.Where(t => t.Nome.StartsWith(txtNomeCliente.Text)); 

                dtgClientes.DataSource = clientes.ToList();
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void frmCadastroClienteConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
