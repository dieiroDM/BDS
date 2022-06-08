using System.Configuration;
using System.Data.SqlClient;

namespace Database
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection();
        public Conexao()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public SqlConnection Abrir()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public SqlConnection Fechar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
