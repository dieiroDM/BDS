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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
