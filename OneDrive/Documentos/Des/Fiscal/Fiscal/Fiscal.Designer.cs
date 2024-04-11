namespace Fiscal
{
    partial class Fiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscal));
            this.CaixaPrincipal = new System.Windows.Forms.GroupBox();
            this.CaixaStatus = new System.Windows.Forms.GroupBox();
            this.lblBloco = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConfiguracoes = new System.Windows.Forms.Button();
            this.BtnContabilista = new System.Windows.Forms.Button();
            this.btnSped = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnSpedCont = new System.Windows.Forms.Button();
            this.btnSintegra = new System.Windows.Forms.Button();
            this.CaixaPrincipal.SuspendLayout();
            this.CaixaStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CaixaPrincipal
            // 
            this.CaixaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.CaixaPrincipal.Controls.Add(this.btnSped);
            this.CaixaPrincipal.Controls.Add(this.pictureBox1);
            this.CaixaPrincipal.Controls.Add(this.btnLivro);
            this.CaixaPrincipal.Controls.Add(this.btnSpedCont);
            this.CaixaPrincipal.Controls.Add(this.btnSintegra);
            this.CaixaPrincipal.Controls.Add(this.CaixaStatus);
            this.CaixaPrincipal.Location = new System.Drawing.Point(27, 15);
            this.CaixaPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.CaixaPrincipal.Name = "CaixaPrincipal";
            this.CaixaPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.CaixaPrincipal.Size = new System.Drawing.Size(776, 377);
            this.CaixaPrincipal.TabIndex = 0;
            this.CaixaPrincipal.TabStop = false;
            this.CaixaPrincipal.Text = "Seleção do arquivo a ser gerado";
            // 
            // CaixaStatus
            // 
            this.CaixaStatus.Controls.Add(this.lblBloco);
            this.CaixaStatus.Controls.Add(this.progressBar2);
            this.CaixaStatus.Controls.Add(this.progressBar1);
            this.CaixaStatus.Location = new System.Drawing.Point(8, 154);
            this.CaixaStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CaixaStatus.Name = "CaixaStatus";
            this.CaixaStatus.Padding = new System.Windows.Forms.Padding(4);
            this.CaixaStatus.Size = new System.Drawing.Size(745, 97);
            this.CaixaStatus.TabIndex = 0;
            this.CaixaStatus.TabStop = false;
            this.CaixaStatus.Text = "Status da geração";
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Location = new System.Drawing.Point(368, 14);
            this.lblBloco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(16, 16);
            this.lblBloco.TabIndex = 6;
            this.lblBloco.Text = "...";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(59, 60);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(644, 20);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 33);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(644, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Blue;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(679, 407);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(101, 28);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "    Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.BackColor = System.Drawing.Color.Blue;
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracoes.Image")));
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(200, 407);
            this.BtnConfiguracoes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Size = new System.Drawing.Size(183, 28);
            this.BtnConfiguracoes.TabIndex = 7;
            this.BtnConfiguracoes.Text = "Configurações";
            this.BtnConfiguracoes.UseVisualStyleBackColor = false;
            this.BtnConfiguracoes.Click += new System.EventHandler(this.BtnConfiguracoes_Click);
            // 
            // BtnContabilista
            // 
            this.BtnContabilista.BackColor = System.Drawing.Color.Blue;
            this.BtnContabilista.FlatAppearance.BorderSize = 0;
            this.BtnContabilista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContabilista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnContabilista.Image = ((System.Drawing.Image)(resources.GetObject("BtnContabilista.Image")));
            this.BtnContabilista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContabilista.Location = new System.Drawing.Point(27, 407);
            this.BtnContabilista.Margin = new System.Windows.Forms.Padding(4);
            this.BtnContabilista.Name = "BtnContabilista";
            this.BtnContabilista.Size = new System.Drawing.Size(165, 28);
            this.BtnContabilista.TabIndex = 6;
            this.BtnContabilista.Text = "Contabilista";
            this.BtnContabilista.UseVisualStyleBackColor = false;
            this.BtnContabilista.Click += new System.EventHandler(this.BtnContabilista_Click);
            // 
            // btnSped
            // 
            this.btnSped.BackgroundImage = global::Fiscal.Properties.Resources.spedC;
            this.btnSped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSped.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSped.FlatAppearance.BorderSize = 0;
            this.btnSped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSped.Location = new System.Drawing.Point(228, 23);
            this.btnSped.Margin = new System.Windows.Forms.Padding(4);
            this.btnSped.Name = "btnSped";
            this.btnSped.Size = new System.Drawing.Size(128, 123);
            this.btnSped.TabIndex = 2;
            this.btnSped.UseVisualStyleBackColor = true;
            this.btnSped.Click += new System.EventHandler(this.BtnSped_Click);
            this.btnSped.MouseEnter += new System.EventHandler(this.btnSped_MouseEnter);
            this.btnSped.MouseLeave += new System.EventHandler(this.btnSped_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(199, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLivro
            // 
            this.btnLivro.BackgroundImage = global::Fiscal.Properties.Resources.lcdprC;
            this.btnLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLivro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Location = new System.Drawing.Point(629, 23);
            this.btnLivro.Margin = new System.Windows.Forms.Padding(4);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(124, 123);
            this.btnLivro.TabIndex = 4;
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.BtnLivro_Click);
            this.btnLivro.MouseEnter += new System.EventHandler(this.btnLivro_MouseEnter);
            this.btnLivro.MouseLeave += new System.EventHandler(this.btnLivro_MouseLeave);
            // 
            // btnSpedCont
            // 
            this.btnSpedCont.BackgroundImage = global::Fiscal.Properties.Resources.sped_contribuicoesC;
            this.btnSpedCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpedCont.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSpedCont.FlatAppearance.BorderSize = 0;
            this.btnSpedCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedCont.Location = new System.Drawing.Point(433, 23);
            this.btnSpedCont.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpedCont.Name = "btnSpedCont";
            this.btnSpedCont.Size = new System.Drawing.Size(125, 124);
            this.btnSpedCont.TabIndex = 4;
            this.btnSpedCont.UseVisualStyleBackColor = true;
            this.btnSpedCont.Click += new System.EventHandler(this.BtnSpedCont_Click);
            this.btnSpedCont.MouseEnter += new System.EventHandler(this.btnSpedCont_MouseEnter);
            this.btnSpedCont.MouseLeave += new System.EventHandler(this.btnSpedCont_MouseLeave);
            // 
            // btnSintegra
            // 
            this.btnSintegra.BackgroundImage = global::Fiscal.Properties.Resources.sintegraC;
            this.btnSintegra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSintegra.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSintegra.FlatAppearance.BorderSize = 0;
            this.btnSintegra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintegra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSintegra.Location = new System.Drawing.Point(24, 23);
            this.btnSintegra.Margin = new System.Windows.Forms.Padding(4);
            this.btnSintegra.Name = "btnSintegra";
            this.btnSintegra.Size = new System.Drawing.Size(123, 123);
            this.btnSintegra.TabIndex = 4;
            this.btnSintegra.Click += new System.EventHandler(this.BtnSintegra_Click);
            this.btnSintegra.MouseEnter += new System.EventHandler(this.btnSintegra_MouseEnter);
            this.btnSintegra.MouseLeave += new System.EventHandler(this.btnSintegra_MouseLeave);
            // 
            // Fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnConfiguracoes);
            this.Controls.Add(this.BtnContabilista);
            this.Controls.Add(this.CaixaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal SG Master || SGBr Sistemas";
            this.Load += new System.EventHandler(this.Fiscal_Load);
            this.CaixaPrincipal.ResumeLayout(false);
            this.CaixaStatus.ResumeLayout(false);
            this.CaixaStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CaixaPrincipal;
        private System.Windows.Forms.GroupBox CaixaStatus;
        private System.Windows.Forms.Button btnSintegra;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnSpedCont;
        private System.Windows.Forms.Button btnSped;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnContabilista;
        private System.Windows.Forms.Button BtnConfiguracoes;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.Button BtnSair;
    }
}

