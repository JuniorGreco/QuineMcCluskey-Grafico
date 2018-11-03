namespace QuineMcCluskey_GraficoC
{
    partial class TelaCarregamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCarregamento));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.lblNomeAplicacao = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.pnBaseBack = new System.Windows.Forms.Panel();
            this.pnBaseFront = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.CornflowerBlue;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(800, 6);
            this.barraSuperior.TabIndex = 0;
            // 
            // lblNomeAplicacao
            // 
            this.lblNomeAplicacao.AutoSize = true;
            this.lblNomeAplicacao.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblNomeAplicacao.ForeColor = System.Drawing.Color.White;
            this.lblNomeAplicacao.Location = new System.Drawing.Point(148, 113);
            this.lblNomeAplicacao.Name = "lblNomeAplicacao";
            this.lblNomeAplicacao.Size = new System.Drawing.Size(347, 92);
            this.lblNomeAplicacao.TabIndex = 1;
            this.lblNomeAplicacao.Text = "Algoritmo \r\nQuine McCluskey";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(501, 182);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(75, 17);
            this.lblVersao.TabIndex = 2;
            this.lblVersao.Text = "versão 1.0";
            // 
            // pnBaseBack
            // 
            this.pnBaseBack.BackColor = System.Drawing.Color.Cornsilk;
            this.pnBaseBack.Location = new System.Drawing.Point(10, 293);
            this.pnBaseBack.Name = "pnBaseBack";
            this.pnBaseBack.Size = new System.Drawing.Size(780, 16);
            this.pnBaseBack.TabIndex = 3;
            // 
            // pnBaseFront
            // 
            this.pnBaseFront.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnBaseFront.Location = new System.Drawing.Point(10, 293);
            this.pnBaseFront.Name = "pnBaseFront";
            this.pnBaseFront.Size = new System.Drawing.Size(20, 16);
            this.pnBaseFront.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(272, 329);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(256, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Carregando módulos complementares..";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(662, 330);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(128, 16);
            this.lblNomeEmpresa.TabIndex = 6;
            this.lblNomeEmpresa.Text = "Rocketz Software";
            // 
            // TelaCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnBaseFront);
            this.Controls.Add(this.pnBaseBack);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblNomeAplicacao);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCarregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Label lblNomeAplicacao;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Panel pnBaseBack;
        private System.Windows.Forms.Panel pnBaseFront;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNomeEmpresa;
    }
}

