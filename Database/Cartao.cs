using System.Data;
using System.Data.SqlClient;

namespace Database
{

    public class Cartao
    {
        public string nomeA, nMat, curso, dataE, dataV;
        public byte[] fotoIMG;

        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();

        public void addCartao(string bi, string dataE, string dataV, byte[] foto)
        {
            try
            {
                string sql = "CriarCartao";
                cmd = new SqlCommand(sql, conn.conn);
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@BI", SqlDbType.VarChar);
                    cmd.Parameters["@BI"].Value = bi;
                    cmd.Parameters.Add("@dataE", SqlDbType.VarChar);
                    cmd.Parameters["@dataE"].Value = dataE;
                    cmd.Parameters.Add("@dataV", SqlDbType.VarChar);
                    cmd.Parameters["@dataV"].Value = dataV;
                    cmd.Parameters.Add("@foto", SqlDbType.Image);
                    cmd.Parameters["@foto"].Value = foto;

                    conn.Abrir();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
            }
        }

        public void add2viaCartao(int id, string dataE, string dataV)
        {
            try
            {
                string sql = "Via2Cartao";
                cmd = new SqlCommand(sql, conn.conn);
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cardID", SqlDbType.VarChar);
                    cmd.Parameters["@cardID"].Value = id;
                    cmd.Parameters.Add("@dataE", SqlDbType.VarChar);
                    cmd.Parameters["@dataE"].Value = dataE;
                    cmd.Parameters.Add("@dataV", SqlDbType.VarChar);
                    cmd.Parameters["@dataV"].Value = dataV;


                    conn.Abrir();
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        public void PesquisaCartao(int id)
        {
            try
            {
                cmd = new SqlCommand("PesquisarCartao", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar);
                    cmd.Parameters["@id"].Value = id;

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            nomeA = dr[0].ToString();
                            nMat = dr[1].ToString();
                            curso = dr[2].ToString();
                            dataE = dr[3].ToString();
                            dataV = dr[4].ToString();
                            fotoIMG = (byte[])dr[5];
                        }
                    }
                    conn.Fechar();
                }
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public int CartoesEmitidos()
        {
            int n = 0;
            cmd = new SqlCommand("TotalCartoes", conn.conn);
            {
                conn.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    n = int.Parse(dr["Resultado"].ToString());
                }
                conn.Fechar();

                return n;
            }

        }

        public int CartoesAtivos()
        {
            int n = 0;
            cmd = new SqlCommand("cartaoValido", conn.conn);
            {
                conn.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    n = int.Parse(dr[0].ToString());
                }
                conn.Fechar();

                return n;
            }
        }

        public int CartoesInvalidos()
        {
            int n = 0;
            cmd = new SqlCommand("cartaoInvalido", conn.conn);
            {
                conn.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    n = int.Parse(dr[0].ToString());
                }
                conn.Fechar();

                return n;
            }
        }
    }
}
