using QuineMcCluskey_GraficoC.View;
using System;
using System.Windows.Forms;

namespace QuineMcCluskey_GraficoC
{
    public partial class TelaCarregamento : Form
    {
        private short contador = 0;

        public TelaCarregamento()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pnBaseFront.Width += 20;
            contador += 1;

            if (pnBaseFront.Width >= pnBaseBack.Width)
            {
                timer.Stop();
                // Tela não responsiva
                //Main Main = new Main();
                //Main.Show();
                TelaPrincipal lay = new TelaPrincipal();
                lay.Show();
                this.Hide();
                //this.Close();
            }
            else
            {
                if (pnBaseFront.Width <= pnBaseBack.Width / 5)
                {
                    if (contador <= 3)
                    lblStatus.Text = "Iniciando..";
                    else
                    lblStatus.Text = "Iniciando...";
                }
                else if (pnBaseFront.Width <= pnBaseBack.Width / 3)
                {
                    if (contador <= 9)
                        lblStatus.Text = "Carregando..";
                    else
                        lblStatus.Text = "Carregando...";
                }
                else if (pnBaseFront.Width <= pnBaseBack.Width / 2)
                {
                    if (contador <= 15)
                        lblStatus.Text = "Carregando módulos..";
                    else
                    lblStatus.Text = "Carregando módulos...";
                }
                else
                {
                    if (contador <= 21)
                        lblStatus.Text = "Carregando módulos complementares..";
                    else
                        lblStatus.Text = "Carregando módulos complementares...";
                }
            }
        }
    }
}
