using System;
using System.Windows.Forms;

namespace QuineMcCluskey_GraficoC.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEscolherTXT_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader readerArquivo = new
                   System.IO.StreamReader(openFileDialog.FileName);
                txtSOP.Text = readerArquivo.ReadToEnd();
                readerArquivo.Close();
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

        }
    }
}
