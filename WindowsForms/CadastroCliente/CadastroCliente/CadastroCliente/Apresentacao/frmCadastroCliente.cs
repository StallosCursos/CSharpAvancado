using System;
using System.Windows.Forms;
using CadastroCliente.InfraEstrutura;
using CadastroCliente.Model;

namespace CadastroCliente.Apresentacao
{
    public partial class frmCadastroCliente : Form
    {
        private Cliente _cliente;
        private ClienteDataContext _dataContext;
        private Endereco _enderecoSelecionado;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _cliente.Id = txtCodigo.Text == "" ? 0 : Int32.Parse(txtCodigo.Text);
            _cliente.Nome = txtNome.Text;

            _dataContext.Clientes.Add(_cliente);
            _dataContext.SaveChanges();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            _dataContext = DataContextFactory.Create();
            _cliente = new Cliente();
            _enderecoSelecionado = new Endereco();
            dtgEmderecos.DataSource = _cliente.Endereco;
        }

        private void frmCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dataContext.Dispose();
        }

        private void btnRemoverEndereco_Click(object sender, EventArgs e)
        {
            _cliente.Endereco.Remove(_enderecoSelecionado);

            dtgEmderecos.DataSource = null;
            dtgEmderecos.DataSource = _cliente.Endereco;
        }

        private void AdicionarEndereco_Click(object sender, EventArgs e)
        {
            _cliente.Endereco.Add(new Endereco
            {
                Cep = txtcep.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogradouro.Text
            });

            dtgEmderecos.DataSource = null; 
            dtgEmderecos.DataSource = _cliente.Endereco;
        }

        private void dtgEmderecos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var endereco = (dtgEmderecos.Rows[e.RowIndex].DataBoundItem as Endereco);
            _enderecoSelecionado = endereco;

            txtcep.Text = _enderecoSelecionado.Cep;
            txtCidade.Text = _enderecoSelecionado.Cidade;
            txtLogradouro.Text = _enderecoSelecionado.Logradouro;
            txtEstado.Text = _enderecoSelecionado.Estado;
        }
    }
}
