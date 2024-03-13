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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> funcionarios = new List<Funcionario>();
            dgvFuncionario.DataSource = funcionarios;
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
                Funcionario funcionario = new Funcionario();
                if (funcionario.RegistroRepetido(txtNome.Text, mkCpf.Text, mkCelular.Text) == true)
                {
                    MessageBox.Show("Funcionário já existe em nossa base de dados!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    mkCpf.Text = "";
                    mkCelular.Text = "";
                    this.txtNome.Focus();
                    return;
                }
                else
                {
                    funcionario.Inserir(txtNome.Text, mkCpf.Text, mkCelular.Text);
                    MessageBox.Show("Funcionário inserida com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> funcionarios = funcionario.listafuncionario();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    mkCpf.Text = "";
                    mkCelular.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxLocalizar_Click(object sender, EventArgs e)
        {
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Localizar(id);
                txtNome.Text = funcionario.nome;
                mkCpf.Text = funcionario.cpf;
                mkCelular.Text = funcionario.celular;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Atualizar(id, txtNome.Text, mkCpf.Text, mkCelular.Text);
                MessageBox.Show("Funcionário atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                dgvFuncionario.DataSource = funcionarios;
                txtId.Text = "";
                txtNome.Text = "";
                mkCpf.Text = "";
                mkCelular.Text = "";
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Excluir(id);
                MessageBox.Show("Funcionário excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                dgvFuncionario.DataSource = funcionarios;
                txtId.Text = "";
                txtNome.Text = "";
                mkCpf.Text = "";
                mkCelular.Text = "";
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                this.dgvFuncionario.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mkCpf.Text = row.Cells[2].Value.ToString();
                mkCelular.Text = row.Cells[3].Value.ToString();
            }
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
        }
    }
}
