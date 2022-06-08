using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class CursoBD
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        public DataTable listaCurso()
        {
            try
            {
                cmd = new SqlCommand("TodosCursos", conn.conn);
                {
                    conn.Abrir();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter daCursos = new SqlDataAdapter(cmd);
                    DataTable dtCursos = new DataTable();
                    daCursos.Fill(dtCursos);
                    conn.Fechar();
                    return dtCursos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
