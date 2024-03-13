using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplataformaDesktop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(2000);
            splash.Close();
        }


        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void ePIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEpi epi = new FrmEpi();
            epi.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntrega entrega = new FrmEntrega();
            entrega.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pbxFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void pbxEpi_Click(object sender, EventArgs e)
        {
            FrmEpi epi = new FrmEpi();
            epi.Show();
        }

        private void pbxEntrega_Click(object sender, EventArgs e)
        {
            FrmEntrega entrega = new FrmEntrega();
            entrega.Show();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
