using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmComponentes : Form
    {
        private string _fileName;

        public frmComponentes()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            openFileDialog.ShowDialog();

            _fileName = openFileDialog.FileName;
            tstFileName.Text = _fileName;
            
            textBox1.Text = _fileName;

            if (!string.IsNullOrEmpty(_fileName))
            {
                string[] lines = File.ReadAllLines(_fileName);
                tstLengthFile.Text = lines.Length.ToString();

                progressBar1.Maximum = lines.Length;

                for (int i = 0; i <= lines.Length; i++)
                    progressBar1.Value = i;

                richTextBox1.Lines = lines;
            }
        }
    }
}
