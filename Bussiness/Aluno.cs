using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Aluno
    {
        public string nome { get; set; }
        public string BI { get; set; }
        public string data { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nMatricula { get; set; }
        public int curso { get; set; }
        public int nivel { get; set; }

        public void salvarAluno()
        {
            new Database.Aluno().AddAluno(this.nome, this.BI, this.data, this.telefone, this.email, this.nMatricula, this.curso, this.nivel);
        }
    }
}
