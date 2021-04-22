
namespace CadastroCliente.Apresentacao
{
    partial class frmCadastroClienteConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.staMenuCliente = new System.Windows.Forms.StatusStrip();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.txtNomeCliente);
            this.pnlFiltros.Controls.Add(this.lblClienteNome);
            this.pnlFiltros.Location = new System.Drawing.Point(-2, -2);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(837, 81);
            this.pnlFiltros.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(735, 27);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 32);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(14, 36);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(431, 23);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Location = new System.Drawing.Point(14, 18);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(40, 15);
            this.lblClienteNome.TabIndex = 6;
            this.lblClienteNome.Text = "Nome";
            // 
            // staMenuCliente
            // 
            this.staMenuCliente.Location = new System.Drawing.Point(0, 535);
            this.staMenuCliente.Name = "staMenuCliente";
            this.staMenuCliente.Size = new System.Drawing.Size(833, 22);
            this.staMenuCliente.TabIndex = 1;
            this.staMenuCliente.Text = "statusStrip1";
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(0, 80);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowTemplate.Height = 25;
            this.dtgClientes.Size = new System.Drawing.Size(833, 397);
            this.dtgClientes.TabIndex = 2;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(670, 490);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(151, 32);
            this.btnNovoCliente.TabIndex = 9;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // frmCadastroClienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 557);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.staMenuCliente);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "frmCadastroClienteConsulta";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.frmCadastroClienteConsulta_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.StatusStrip staMenuCliente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnNovoCliente;
    }
}