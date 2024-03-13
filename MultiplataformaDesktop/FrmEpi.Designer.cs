namespace MultiplataformaDesktop
{
    partial class FrmEpi
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxExcluir = new System.Windows.Forms.PictureBox();
            this.pbxEditar = new System.Windows.Forms.PictureBox();
            this.pbxInserir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEpi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkValidade = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEpi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpi)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(820, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "SAIR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(803, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "EXCLUIR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(808, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "EDITAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(803, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "INSERIR";
            // 
            // pbxSair
            // 
            this.pbxSair.BackColor = System.Drawing.Color.Transparent;
            this.pbxSair.Image = global::MultiplataformaDesktop.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(797, 393);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(85, 71);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 69;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // pbxExcluir
            // 
            this.pbxExcluir.BackColor = System.Drawing.Color.Transparent;
            this.pbxExcluir.Image = global::MultiplataformaDesktop.Properties.Resources.excluir;
            this.pbxExcluir.Location = new System.Drawing.Point(797, 274);
            this.pbxExcluir.Name = "pbxExcluir";
            this.pbxExcluir.Size = new System.Drawing.Size(85, 71);
            this.pbxExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExcluir.TabIndex = 68;
            this.pbxExcluir.TabStop = false;
            // 
            // pbxEditar
            // 
            this.pbxEditar.BackColor = System.Drawing.Color.Transparent;
            this.pbxEditar.Image = global::MultiplataformaDesktop.Properties.Resources.editar;
            this.pbxEditar.Location = new System.Drawing.Point(797, 157);
            this.pbxEditar.Name = "pbxEditar";
            this.pbxEditar.Size = new System.Drawing.Size(85, 71);
            this.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEditar.TabIndex = 67;
            this.pbxEditar.TabStop = false;
            // 
            // pbxInserir
            // 
            this.pbxInserir.BackColor = System.Drawing.Color.Transparent;
            this.pbxInserir.Image = global::MultiplataformaDesktop.Properties.Resources.adicionar;
            this.pbxInserir.Location = new System.Drawing.Point(797, 33);
            this.pbxInserir.Name = "pbxInserir";
            this.pbxInserir.Size = new System.Drawing.Size(85, 71);
            this.pbxInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInserir.TabIndex = 66;
            this.pbxInserir.TabStop = false;
            this.pbxInserir.Click += new System.EventHandler(this.pbxInserir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MultiplataformaDesktop.Properties.Resources.localizar;
            this.pictureBox1.Location = new System.Drawing.Point(147, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 20);
            this.txtId.TabIndex = 74;
            // 
            // txtEpi
            // 
            this.txtEpi.Location = new System.Drawing.Point(39, 143);
            this.txtEpi.Name = "txtEpi";
            this.txtEpi.Size = new System.Drawing.Size(277, 20);
            this.txtEpi.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "EPI";
            // 
            // mkValidade
            // 
            this.mkValidade.Location = new System.Drawing.Point(39, 229);
            this.mkValidade.Mask = "00/00/0000";
            this.mkValidade.Name = "mkValidade";
            this.mkValidade.Size = new System.Drawing.Size(154, 20);
            this.mkValidade.TabIndex = 80;
            this.mkValidade.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "VALIDADE";
            // 
            // dgvEpi
            // 
            this.dgvEpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpi.Location = new System.Drawing.Point(39, 364);
            this.dgvEpi.Name = "dgvEpi";
            this.dgvEpi.Size = new System.Drawing.Size(709, 150);
            this.dgvEpi.TabIndex = 81;
            // 
            // FrmEpi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiplataformaDesktop.Properties.Resources.cr7real;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 526);
            this.Controls.Add(this.dgvEpi);
            this.Controls.Add(this.mkValidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEpi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxExcluir);
            this.Controls.Add(this.pbxEditar);
            this.Controls.Add(this.pbxInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEpi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIPLATAFORMA - DESKTOP";
            this.Load += new System.EventHandler(this.FrmEpi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.PictureBox pbxExcluir;
        private System.Windows.Forms.PictureBox pbxEditar;
        private System.Windows.Forms.PictureBox pbxInserir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkValidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEpi;
    }
}