using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmissorCartao
{
    public partial class Consulta : Form
    {
        private int cardID;

        public Consulta()
        {
            InitializeComponent();
            carregarEstatisticas();
        }

        private void carregarEstatisticas()
        {
            try
            {
                Bussiness.Cartao card = new Bussiness.Cartao();
                lbCardEmitidos.Text = card.CartoesEmitidos().ToString();
                lbCardAtivos.Text = card.CartoesAtivos().ToString();
                lbcardInativos.Text = card.CartoesInvalidos().ToString();

                Bussiness.Aluno aluno = new Bussiness.Aluno();
                lbAlunosSemCard.Text = aluno.TotalSemCartoes().ToString();
            }
            catch
            { }
        }

        private void mostrarAlunos()
        {
            try
            {
                Bussiness.Aluno aluno = new Bussiness.Aluno();
                dgAlunos.DataSource = aluno.listarAlunosComCartao();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mostrarCard()
        {
            try
            {
                Bussiness.Cartao card = new Bussiness.Cartao();
                card.PesquisaCartao(cardID);

                lbNome.Text = card.nomeA;
                lbNMat.Text = card.nMat;
                lbCurso.Text = card.curso;
                lbDataE.Text = card.dataE;
                lbDataV.Text = card.dataV;

                using (var foto = new MemoryStream(card.fotoCard))
                {
                    pictureBox1.Image = Image.FromStream(foto);
                }
                btn2via.Enabled = true;
                btnPrint.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pesquisarAlunos()
        {
            if (!string.IsNullOrEmpty(txtPalavraChave.Text))
            {
                try
                {
                    Bussiness.Aluno aluno = new Bussiness.Aluno();
                    dgAlunos.DataSource = aluno.PesquisarComCartao(txtPalavraChave.Text);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Inicio INI = new Inicio();
                INI.Show();
                this.Close();
            }
            catch { }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            mostrarAlunos();
            carregarEstatisticas();
        }

        private void txtPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPalavraChave.Text))
            {
                pesquisarAlunos();
            }
            else
            {
                mostrarAlunos();
            }
        }

        private void dgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow CardSelecionado = dgAlunos.Rows[index];
                cardID = int.Parse(CardSelecionado.Cells[5].Value.ToString());
                if (cardID >= 0)
                {
                    mostrarCard();
                }
            }
            catch
            { }
        }

        private void btn2via_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Emitir a 2ª via deste Cartão?", "Emitir 2ª Via", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bussiness.Cartao via2 = new Bussiness.Cartao();
                via2.via2cartao(cardID);
                if (via2.certo == true)
                {
                    MessageBox.Show("2ª via Emitida com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cardID != 0)
            {
                Bussiness.ImprimirCartao imprimir = new Bussiness.ImprimirCartao(lbNome.Text, lbNMat.Text, lbCurso.Text, lbDataE.Text, lbDataV.Text);
            }
        }
    }
}
