using System;
using System.Data;

namespace Bussiness
{
    public class CursoBAL
    {
        public DataTable listarCursos()
        {
            try
            {
                DataTable lista = new Database.CursoBD().listaCurso();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
