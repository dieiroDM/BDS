using System;
using System.Windows.Forms;

namespace EmissorCartao
{
    public partial class emitirCartao : Form
    {
        string caminhoFoto = "", nBI = null;
        public emitirCartao()
        {
            InitializeComponent();
        }

        private void selecionarFoto()
        {
            try
            {
                OpenFileDialog caixaSelecao = new OpenFileDialog();
                caixaSelecao.Filter = "png files(*.png)|*.png| jpg files(*.jpg)|*.jpg";
                if (caixaSelecao.ShowDialog() == DialogResult.OK)
                {
                    caminhoFoto = caixaSelecao.FileName.ToString();
                    picFotoAluno.ImageLocation = caminhoFoto;
                }
            }
            catch { }
        }
        private void mostrarAlunos()
        {
            try
            {
                Bussiness.Aluno aluno = new Bussiness.Aluno();
                dgAlunos.DataSource = aluno.listarAlunosSemCartao();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void picFotoAluno_Click(object sender, EventArgs e)
        {
            selecionarFoto();
        }

        private void emitirCartao_Load(object sender, EventArgs e)
        {

            mostrarAlunos();
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            mostrarAlunos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelarCard();
            try
            {
                Inicio INI = new Inicio();
                INI.Show();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelarCard();
        }

        private void cancelarCard()
        {
            gbEmitirCartao.Visible = false;
            gbEmitirCartao.SendToBack();
            picFotoAluno.Image = null;
            dgAlunos.Visible = true;

            btnNext.Visible = true;
            btnAtualizarLista.Visible = true;

            gbEmitirCartao.Visible = false;
            nBI = null;
            btnNext.Enabled = false;
            lb_title.Text = "SELECIONAR O ALUNO";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnAtualizarLista.Visible = false;
            lbDataE.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lbDataV.Text = DateTime.Now.ToString("dd-MM") + "-" + (DateTime.Now.Year + 3).ToString();



            dgAlunos.Visible = false;

            gbEmitirCartao.Visible = true;
            gbEmitirCartao.BringToFront();
            lb_title.Text = "CARREGAR FOTO A PARTIR DOS ARQUIVOS OU TIRAR FOTO";

        }

        private void btnTerminarCard_Click(object sender, EventArgs e)
        {
            if (picFotoAluno.Image != null && !string.IsNullOrEmpty(nBI))
            {
                Bussiness.Cartao cartao = new Bussiness.Cartao();
                cartao.BI = nBI;
                cartao.caminhoFoto = caminhoFoto;
                cartao.ADD_C();

                if (cartao.certo == true)
                {
                    MessageBox.Show("Cartão Emitido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cancelarCard();
                }
                else
                {
                    MessageBox.Show("Erro ao emitir o Cartão\nTente Novamente mais tarde", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Deve selecionar uma foto existente ou Tirar uma nova", "Foto do Estudante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPalavrachave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPalavrachave.Text))
            {
                pesquisarAluno();
            }
            else
            {
                mostrarAlunos();
            }
        }

        private void pesquisarAluno()
        {
            try
            {
                Bussiness.Aluno aluno = new Bussiness.Aluno();
                dgAlunos.DataSource = aluno.PesquisarSemCartao(txtPalavrachave.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow alunoSelecionado = dgAlunos.Rows[index];
                lbNomeAluno.Text = alunoSelecionado.Cells[0].Value.ToString();
                nBI = alunoSelecionado.Cells[1].Value.ToString();
                lbNMatricula.Text = alunoSelecionado.Cells[2].Value.ToString();
                lbCurso.Text = alunoSelecionado.Cells[3].Value.ToString();


                if (!string.IsNullOrEmpty(nBI))
                {
                    btnNext.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
