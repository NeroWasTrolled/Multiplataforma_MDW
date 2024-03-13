using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplataformaDesktop
{
    public partial class FrmEpi : Form
    {
        public FrmEpi()
        {
            InitializeComponent();
        }

        private void FrmEpi_Load(object sender, EventArgs e)
        {
            Epi epi = new Epi();
            List<Epi> epis = new List<Epi>();
            dgvEpi.DataSource = epis;
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Epi epi = new Epi();
                if (DateTime.TryParse(mkValidade.Text, out DateTime validade))
                {
                    if (epi.RegistroRepetido(txtEpi.Text, validade) == true)
                    {
                        MessageBox.Show("Epi já existe em nossa base de dados!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEpi.Text = "";
                        mkValidade.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        this.txtEpi.Focus();
                        return;
                    }
                    else
                    {
                        epi.Inserir(txtEpi.Text, validade); 
                        MessageBox.Show("Epi inserida com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<Epi> epis = epi.listaepi();
                        dgvEpi.DataSource = epis;
                        txtEpi.Text = "";
                        mkValidade.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        this.txtEpi.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
