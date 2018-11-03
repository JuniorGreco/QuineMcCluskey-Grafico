namespace QuineMcCluskey_GraficoC
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.lblNomeAplicacao = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
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
            this.lblNomeAplicacao.Location = new System.Drawing.Point(113, 212);
            this.lblNomeAplicacao.Name = "lblNomeAplicacao";
            this.lblNomeAplicacao.Size = new System.Drawing.Size(347, 46);
            this.lblNomeAplicacao.TabIndex = 1;
            this.lblNomeAplicacao.Text = "Quine McCluskey";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(466, 241);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(75, 17);
            this.lblVersao.TabIndex = 2;
            this.lblVersao.Text = "versão 1.0";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblNomeAplicacao);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Label lblNomeAplicacao;
        private System.Windows.Forms.Label lblVersao;
    }
}

