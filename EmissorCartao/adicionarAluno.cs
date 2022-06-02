using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmissorCartao
{
    public partial class adicionarAluno : Form
    {
        public adicionarAluno()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome = txtNome.Text;
            aluno.BI = txtNBI.Text;
            aluno.data = dtNascimento.Text;
            aluno.telefone = txtTelefone.Text;
            aluno.email = txtEmail.Text;
            aluno.curso = int.Parse(cbCurso.Text);
            aluno.nivel = int.Parse(cbNivel.Text);
            aluno.nMatricula = "0909";
            aluno.salvarAluno();
        }
    }
}
