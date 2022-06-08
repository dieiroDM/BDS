using System;
using System.Data;

namespace Bussiness
{
    public class Aluno
    {
        public bool certo = false;
        private string nome;
        private string bI;
        private string data;
        private string telefone;
        private string email;
        private int curso;
        private int nivel;

        public string Nome { get => nome; set => nome = value; }
        public string BI { get => bI; set => bI = value; }
        public string Data { get => data; set => data = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Curso { get => curso; set => curso = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        public void salvarAluno()
        {
            try
            {
                new Database.Aluno().AddAluno(this.Nome, this.BI, this.Data, this.Telefone, this.Email, this.Curso, this.Nivel);
                certo = true;
            }
            catch (Exception)
            {
            }
        }

        public int TotalSemCartoes()
        {
            return new Database.Aluno().TotalSemCartoes();
        }

        public DataTable listarAlunosSemCartao()
        {
            try
            {
                DataTable lista = new Database.Aluno().ListaAlunosSemCartao();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable listarAlunosComCartao()
        {
            try
            {
                DataTable lista = new Database.Aluno().ListaAlunosComCartao();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarComCartao(string nome_BI)
        {
            try
            {
                DataTable lista = new Database.Aluno().PesquisaComCartao(nome_BI);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarSemCartao(string nome_BI)
        {
            try
            {
                DataTable lista = new Database.Aluno().PesquisaSemCartao(nome_BI);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
