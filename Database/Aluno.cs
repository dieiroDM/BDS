using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Aluno
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();

        public void AddAluno(string nome, string BI, string dataNasc, string telefone, string email, int curso, int nivel)
        {
            cmd = new SqlCommand("AdicionaAluno", conn.conn);
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = nome;

                cmd.Parameters.Add("@BI", SqlDbType.VarChar);
                cmd.Parameters["@BI"].Value = BI;

                cmd.Parameters.Add("@data", SqlDbType.VarChar);
                cmd.Parameters["@data"].Value = dataNasc;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = telefone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@curso", SqlDbType.Int);
                cmd.Parameters["@curso"].Value = curso;

                cmd.Parameters.Add("@nivel", SqlDbType.Int);
                cmd.Parameters["@nivel"].Value = nivel;

                conn.Abrir();
                cmd.ExecuteNonQuery();
            }
        }

        public int TotalSemCartoes()
        {
            int n = 0;
            try
            {

                cmd = new SqlCommand("TotalSemCartao", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        n = int.Parse(dr[0].ToString());
                        dr.Close();
                    }

                }
            }
            catch
            { }
            return n;
        }

        public DataTable ListaAlunosSemCartao()
        {
            try
            {

                cmd = new SqlCommand("AlunoSemCartao", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter daAlunos = new SqlDataAdapter(cmd);
                    DataTable dtAlunos = new DataTable();
                    daAlunos.Fill(dtAlunos);
                    conn.Fechar();
                    return dtAlunos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListaAlunosComCartao()
        {
            try
            {

                cmd = new SqlCommand("AlunoComCartao", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter daAlunos = new SqlDataAdapter(cmd);
                    DataTable dtAlunos = new DataTable();
                    daAlunos.Fill(dtAlunos);
                    conn.Fechar();
                    return dtAlunos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable PesquisaSemCartao(string palavraChave)
        {
            try
            {

                cmd = new SqlCommand("PesquisaSemCartao", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@palavraChave", SqlDbType.VarChar);
                    cmd.Parameters["@palavraChave"].Value = palavraChave;
                    SqlDataAdapter daAlunos = new SqlDataAdapter(cmd);
                    DataTable dtAlunos = new DataTable();
                    daAlunos.Fill(dtAlunos);
                    conn.Fechar();
                    return dtAlunos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable PesquisaComCartao(string palavraChave)
        {
            try
            {

                cmd = new SqlCommand("PesquisaComCartao", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@palavraChave", SqlDbType.VarChar);
                    cmd.Parameters["@palavraChave"].Value = palavraChave;
                    SqlDataAdapter daAlunos = new SqlDataAdapter(cmd);
                    DataTable dtAlunos = new DataTable();
                    daAlunos.Fill(dtAlunos);
                    conn.Fechar();
                    return dtAlunos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
