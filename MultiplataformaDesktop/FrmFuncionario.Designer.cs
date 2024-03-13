namespace MultiplataformaDesktop
{
    partial class FrmFuncionario
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLocalizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mkCpf = new System.Windows.Forms.MaskedTextBox();
            this.mkCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.pbxInserir = new System.Windows.Forms.PictureBox();
            this.pbxEditar = new System.Windows.Forms.PictureBox();
            this.pbxExcluir = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(30, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 20);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // pbxLocalizar
            // 
            this.pbxLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.pbxLocalizar.Image = global::MultiplataformaDesktop.Properties.Resources.localizar;
            this.pbxLocalizar.Location = new System.Drawing.Point(138, 27);
            this.pbxLocalizar.Name = "pbxLocalizar";
            this.pbxLocalizar.Size = new System.Drawing.Size(64, 50);
            this.pbxLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLocalizar.TabIndex = 2;
            this.pbxLocalizar.TabStop = false;
            this.pbxLocalizar.Click += new System.EventHandler(this.pbxLocalizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // mkCpf
            // 
            this.mkCpf.Location = new System.Drawing.Point(30, 215);
            this.mkCpf.Mask = "000.000.000-00";
            this.mkCpf.Name = "mkCpf";
            this.mkCpf.Size = new System.Drawing.Size(154, 20);
            this.mkCpf.TabIndex = 6;
            // 
            // mkCelular
            // 
            this.mkCelular.Location = new System.Drawing.Point(30, 297);
            this.mkCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mkCelular.Mask = "(00)00000-0000";
            this.mkCelular.Name = "mkCelular";
            this.mkCelular.Size = new System.Drawing.Size(193, 20);
            this.mkCelular.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "CELULAR";
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(30, 335);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(604, 150);
            this.dgvFuncionario.TabIndex = 57;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // pbxInserir
            // 
            this.pbxInserir.BackColor = System.Drawing.Color.Transparent;
            this.pbxInserir.Image = global::MultiplataformaDesktop.Properties.Resources.adicionar;
            this.pbxInserir.Location = new System.Drawing.Point(669, 27);
            this.pbxInserir.Name = "pbxInserir";
            this.pbxInserir.Size = new System.Drawing.Size(85, 71);
            this.pbxInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInserir.TabIndex = 58;
            this.pbxInserir.TabStop = false;
            this.pbxInserir.Click += new System.EventHandler(this.pbxInserir_Click);
            // 
            // pbxEditar
            // 
            this.pbxEditar.BackColor = System.Drawing.Color.Transparent;
            this.pbxEditar.Image = global::MultiplataformaDesktop.Properties.Resources.editar;
            this.pbxEditar.Location = new System.Drawing.Point(669, 151);
            this.pbxEditar.Name = "pbxEditar";
            this.pbxEditar.Size = new System.Drawing.Size(85, 71);
            this.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEditar.TabIndex = 59;
            this.pbxEditar.TabStop = false;
            this.pbxEditar.Click += new System.EventHandler(this.pbxEditar_Click);
            // 
            // pbxExcluir
            // 
            this.pbxExcluir.BackColor = System.Drawing.Color.Transparent;
            this.pbxExcluir.Image = global::MultiplataformaDesktop.Properties.Resources.excluir;
            this.pbxExcluir.Location = new System.Drawing.Point(669, 268);
            this.pbxExcluir.Name = "pbxExcluir";
            this.pbxExcluir.Size = new System.Drawing.Size(85, 71);
            this.pbxExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExcluir.TabIndex = 60;
            this.pbxExcluir.TabStop = false;
            this.pbxExcluir.Click += new System.EventHandler(this.pbxExcluir_Click);
            // 
            // pbxSair
            // 
            this.pbxSair.BackColor = System.Drawing.Color.Transparent;
            this.pbxSair.Image = global::MultiplataformaDesktop.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(669, 387);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(85, 71);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 61;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(675, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "INSERIR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(680, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "EDITAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(675, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "EXCLUIR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(692, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "SAIR";
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiplataformaDesktop.Properties.Resources.cr7Juventus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxExcluir);
            this.Controls.Add(this.pbxEditar);
            this.Controls.Add(this.pbxInserir);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.mkCelular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mkCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxLocalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIPLATAFORMA - DESKTOP";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxLocalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mkCpf;
        private System.Windows.Forms.MaskedTextBox mkCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.PictureBox pbxInserir;
        private System.Windows.Forms.PictureBox pbxEditar;
        private System.Windows.Forms.PictureBox pbxExcluir;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}