using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Database
{
    public class Aluno
    {
        private string stringConexao = "";
        public Aluno()
        {
            stringConexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public void AddAluno(string nome, string BI, string dataNasc, string telefone, string email, string nMatricula, int curso, int nivel)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                string sql = "AdicionaAluno";
                SqlCommand cmd = new SqlCommand(sql, conn);
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

                    cmd.Parameters.Add("@matricula", SqlDbType.VarChar);
                    cmd.Parameters["@matricula"].Value = nMatricula;

                    cmd.Parameters.Add("@curso", SqlDbType.Int);
                    cmd.Parameters["@curso"].Value = curso;

                    cmd.Parameters.Add("@nivel", SqlDbType.Int);
                    cmd.Parameters["@nivel"].Value = nivel;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
