using QuineMcCluskey_GraficoC.Model;
using QuineMcCluskey_GraficoC.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuineMcCluskey_GraficoC.View
{
    public partial class TelaPrincipal : Form
    {
        private string caminhoArquivo = "";

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnEscolherTXT_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = openFileDialog.FileName;
                var readerArquivo = new StreamReader(caminhoArquivo);
                txtSOP.Text = readerArquivo.ReadToEnd();
                readerArquivo.Close();
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // Carrega todos os Mintermos e Don't Cares do arquivo TXT
            List<Mintermo> ColunaMintermos = ViewMain.CarregarMintermosDoTXT(caminhoArquivo);

            // Executa o Método responsável pelo Quine McCluskey
            QuineMcCluskey Quine = new QuineMcCluskey(ViewMain.numVariaveis);
            Quine.Executa(ColunaMintermos, txtLog);
        }
    }
}
