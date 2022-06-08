using System;
using System.Windows.Forms;

namespace EmissorCartao
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            try
            {
                adicionarAluno Form_Add_Aluno = new adicionarAluno();
                Form_Add_Aluno.Show();
                this.Hide();
            }
            catch { }
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            try
            {
                emitirCartao EC = new emitirCartao();
                EC.Show();
                this.Hide();
            }
            catch { }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta consulta = new Consulta();
                consulta.Show();
                this.Hide();
            }
            catch { }
        }
    }
}
