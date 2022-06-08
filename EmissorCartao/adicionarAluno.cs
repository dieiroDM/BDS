using Bussiness;
using System;
using System.Windows.Forms;

namespace EmissorCartao
{
    public partial class adicionarAluno : Form
    {
        public adicionarAluno()
        {
            InitializeComponent();
        }
        private void limparCampos()
        {
            txtEmail.Clear();
            txtNBI.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                if (!string.IsNullOrEmpty(txtNBI.Text))
                {
                    if (!string.IsNullOrEmpty(txtTelefone.Text))
                    {
                        Aluno aluno = new Aluno();
                        aluno.Nome = txtNome.Text;
                        aluno.BI = txtNBI.Text;
                        aluno.Data = dtNascimento.Text;
                        aluno.Telefone = txtTelefone.Text;
                        aluno.Email = txtEmail.Text;
                        aluno.Curso = int.Parse(cbCurso.SelectedValue.ToString());
                        aluno.Nivel = int.Parse(cbNivel.Text);
                        aluno.salvarAluno();
                        if (aluno.certo == true)
                        {
                            MessageBox.Show("Aluno Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Cadastrar o Aluno\nTente Novamente mais tarde", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        lbErro.Text = "Insira o Número de Telefone do Aluno";
                        lbErro.Visible = true;

                        txtTelefone.Focus();
                        txtTelefone.SelectAll();
                    }
                }
                else
                {

                    lbErro.Text = "Número de BI inválido";
                    lbErro.Visible = true;

                    txtNBI.Focus();
                    txtNBI.SelectAll();
                }
            }
            else
            {

                lbErro.Text = "Insira o Nome do Aluno";
                lbErro.Visible = true;

                txtNome.Focus();
                txtNome.SelectAll();
            }





        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                limparCampos();
                Inicio INI = new Inicio();
                INI.Show();
                this.Close();

            }
            catch { }
        }

        private void adicionarAluno_Load(object sender, EventArgs e)
        {
            try
            {
                CursoBAL curso = new CursoBAL();
                cbCurso.DataSource = curso.listarCursos();
                cbCurso.DisplayMember = "curso";
                cbCurso.ValueMember = "id";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void dtNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
