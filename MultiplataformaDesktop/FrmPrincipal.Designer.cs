namespace MultiplataformaDesktop
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ePIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxFuncionario = new System.Windows.Forms.PictureBox();
            this.pbxEpi = new System.Windows.Forms.PictureBox();
            this.pbxEntrega = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEpi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.entregaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.ePIToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // ePIToolStripMenuItem
            // 
            this.ePIToolStripMenuItem.Name = "ePIToolStripMenuItem";
            this.ePIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ePIToolStripMenuItem.Text = "EPI";
            this.ePIToolStripMenuItem.Click += new System.EventHandler(this.ePIToolStripMenuItem_Click);
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.entregaToolStripMenuItem.Text = "Entrega";
            this.entregaToolStripMenuItem.Click += new System.EventHandler(this.entregaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(118, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SAIR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(118, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ENTREGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(118, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "EPI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(118, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "FUNCIONÁRIO";
            // 
            // pbxFuncionario
            // 
            this.pbxFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.pbxFuncionario.Image = global::MultiplataformaDesktop.Properties.Resources.funcionario;
            this.pbxFuncionario.Location = new System.Drawing.Point(12, 39);
            this.pbxFuncionario.Name = "pbxFuncionario";
            this.pbxFuncionario.Size = new System.Drawing.Size(100, 85);
            this.pbxFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFuncionario.TabIndex = 14;
            this.pbxFuncionario.TabStop = false;
            this.pbxFuncionario.Click += new System.EventHandler(this.pbxFuncionario_Click);
            // 
            // pbxEpi
            // 
            this.pbxEpi.BackColor = System.Drawing.Color.Transparent;
            this.pbxEpi.Image = global::MultiplataformaDesktop.Properties.Resources.epi;
            this.pbxEpi.Location = new System.Drawing.Point(12, 140);
            this.pbxEpi.Name = "pbxEpi";
            this.pbxEpi.Size = new System.Drawing.Size(100, 85);
            this.pbxEpi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEpi.TabIndex = 13;
            this.pbxEpi.TabStop = false;
            this.pbxEpi.Click += new System.EventHandler(this.pbxEpi_Click);
            // 
            // pbxEntrega
            // 
            this.pbxEntrega.BackColor = System.Drawing.Color.Transparent;
            this.pbxEntrega.Image = global::MultiplataformaDesktop.Properties.Resources.entrega;
            this.pbxEntrega.Location = new System.Drawing.Point(12, 242);
            this.pbxEntrega.Name = "pbxEntrega";
            this.pbxEntrega.Size = new System.Drawing.Size(100, 85);
            this.pbxEntrega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEntrega.TabIndex = 12;
            this.pbxEntrega.TabStop = false;
            this.pbxEntrega.Click += new System.EventHandler(this.pbxEntrega_Click);
            // 
            // pbxSair
            // 
            this.pbxSair.BackColor = System.Drawing.Color.Transparent;
            this.pbxSair.Image = ((System.Drawing.Image)(resources.GetObject("pbxSair.Image")));
            this.pbxSair.Location = new System.Drawing.Point(12, 342);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(100, 82);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 11;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiplataformaDesktop.Properties.Resources.cr7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxFuncionario);
            this.Controls.Add(this.pbxEpi);
            this.Controls.Add(this.pbxEntrega);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIPLATAFORMA - DESKTOP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEpi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ePIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxFuncionario;
        private System.Windows.Forms.PictureBox pbxEpi;
        private System.Windows.Forms.PictureBox pbxEntrega;
        private System.Windows.Forms.PictureBox pbxSair;
    }
}

