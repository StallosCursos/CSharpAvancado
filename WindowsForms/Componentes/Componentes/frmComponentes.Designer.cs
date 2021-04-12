
namespace Componentes
{
    partial class frmComponentes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.btnClick = new System.Windows.Forms.Button();
            this.lblOpenDialog = new System.Windows.Forms.Label();
            this.chkOpcao = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stsFileName = new System.Windows.Forms.StatusStrip();
            this.tstFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstLengthFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stsFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(12, 48);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(111, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblOpenDialog
            // 
            this.lblOpenDialog.AutoSize = true;
            this.lblOpenDialog.Location = new System.Drawing.Point(12, 20);
            this.lblOpenDialog.Name = "lblOpenDialog";
            this.lblOpenDialog.Size = new System.Drawing.Size(73, 15);
            this.lblOpenDialog.TabIndex = 1;
            this.lblOpenDialog.Text = "Open Dialog";
            // 
            // chkOpcao
            // 
            this.chkOpcao.AutoSize = true;
            this.chkOpcao.Location = new System.Drawing.Point(12, 113);
            this.chkOpcao.Name = "chkOpcao";
            this.chkOpcao.Size = new System.Drawing.Size(70, 19);
            this.chkOpcao.TabIndex = 2;
            this.chkOpcao.Text = "Opção 1";
            this.chkOpcao.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 - Todos",
            "2 - Contato",
            "3 - Comercial"});
            this.comboBox1.Location = new System.Drawing.Point(155, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(431, 58);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(103, 23);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(684, 24);
            this.progressBar1.TabIndex = 6;
            // 
            // stsFileName
            // 
            this.stsFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstFileName,
            this.tstLengthFile});
            this.stsFileName.Location = new System.Drawing.Point(0, 555);
            this.stsFileName.Name = "stsFileName";
            this.stsFileName.Size = new System.Drawing.Size(715, 22);
            this.stsFileName.TabIndex = 7;
            // 
            // tstFileName
            // 
            this.tstFileName.Name = "tstFileName";
            this.tstFileName.Size = new System.Drawing.Size(98, 17);
            this.tstFileName.Text = "tstFileNameLabel";
            // 
            // tstLengthFile
            // 
            this.tstLengthFile.Name = "tstLengthFile";
            this.tstLengthFile.Size = new System.Drawing.Size(118, 17);
            this.tstLengthFile.Text = "toolStripStatusLabel2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(684, 309);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(684, 23);
            this.textBox1.TabIndex = 9;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 577);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.stsFileName);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkOpcao);
            this.Controls.Add(this.lblOpenDialog);
            this.Controls.Add(this.btnClick);
            this.Name = "frmComponentes";
            this.Text = "Componentes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stsFileName.ResumeLayout(false);
            this.stsFileName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblOpenDialog;
        private System.Windows.Forms.CheckBox chkOpcao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip stsFileName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tstFileName;
        private System.Windows.Forms.ToolStripStatusLabel tstLengthFile;
    }
}

