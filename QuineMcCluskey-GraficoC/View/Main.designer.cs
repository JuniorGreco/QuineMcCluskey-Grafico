namespace QuineMcCluskey_GraficoC.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtSOP = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnEscolherTXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDigite = new System.Windows.Forms.Label();
            this.lblExemploSOP = new System.Windows.Forms.Label();
            this.lblCarregue = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSOP
            // 
            this.txtSOP.BackColor = System.Drawing.Color.White;
            this.txtSOP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOP.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtSOP.Location = new System.Drawing.Point(177, 9);
            this.txtSOP.Multiline = true;
            this.txtSOP.Name = "txtSOP";
            this.txtSOP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSOP.ShortcutsEnabled = false;
            this.txtSOP.Size = new System.Drawing.Size(695, 215);
            this.txtSOP.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnEscolherTXT
            // 
            this.btnEscolherTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEscolherTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherTXT.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherTXT.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnEscolherTXT.Location = new System.Drawing.Point(16, 176);
            this.btnEscolherTXT.Name = "btnEscolherTXT";
            this.btnEscolherTXT.Size = new System.Drawing.Size(126, 48);
            this.btnEscolherTXT.TabIndex = 4;
            this.btnEscolherTXT.Text = "Escolher TXT";
            this.btnEscolherTXT.UseVisualStyleBackColor = false;
            this.btnEscolherTXT.Click += new System.EventHandler(this.btnEscolherTXT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDigite.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigite.ForeColor = System.Drawing.Color.White;
            this.lblDigite.Location = new System.Drawing.Point(12, 9);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(119, 24);
            this.lblDigite.TabIndex = 6;
            this.lblDigite.Text = "Digite a SOP:";
            // 
            // lblExemploSOP
            // 
            this.lblExemploSOP.AutoSize = true;
            this.lblExemploSOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExemploSOP.Font = new System.Drawing.Font("Candara", 13F);
            this.lblExemploSOP.ForeColor = System.Drawing.Color.White;
            this.lblExemploSOP.Location = new System.Drawing.Point(12, 35);
            this.lblExemploSOP.Name = "lblExemploSOP";
            this.lblExemploSOP.Size = new System.Drawing.Size(159, 88);
            this.lblExemploSOP.TabIndex = 7;
            this.lblExemploSOP.Text = "Exemplo\r\nMintermos: 0;17;\r\nDon\'t Cares: -4; -25;\r\nSOP: 0;-4;17;-25;";
            // 
            // lblCarregue
            // 
            this.lblCarregue.AutoSize = true;
            this.lblCarregue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarregue.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregue.ForeColor = System.Drawing.Color.White;
            this.lblCarregue.Location = new System.Drawing.Point(12, 140);
            this.lblCarregue.Name = "lblCarregue";
            this.lblCarregue.Size = new System.Drawing.Size(153, 24);
            this.lblCarregue.TabIndex = 8;
            this.lblCarregue.Text = "Carregue do TXT";
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.CornflowerBlue;
            this.barraSuperior.Location = new System.Drawing.Point(0, 236);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(900, 4);
            this.barraSuperior.TabIndex = 9;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtLog.Location = new System.Drawing.Point(177, 248);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.ShortcutsEnabled = false;
            this.txtLog.Size = new System.Drawing.Size(695, 253);
            this.txtLog.TabIndex = 10;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnExecutar.Location = new System.Drawing.Point(16, 352);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(126, 48);
            this.btnExecutar.TabIndex = 11;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.lblCarregue);
            this.Controls.Add(this.lblExemploSOP);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscolherTXT);
            this.Controls.Add(this.txtSOP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quine McCluskey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSOP;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnEscolherTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Label lblExemploSOP;
        private System.Windows.Forms.Label lblCarregue;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnExecutar;
    }
}