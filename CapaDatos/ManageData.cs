using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ManageData
    {
        private Connection conn = new Connection();

        public DataTable ejecutaSP_Query(string nombre_sp, List<SqlParameter> lista)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            if (lista != null)
            {
                command.Parameters.AddRange(lista.ToArray());
            }
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public bool ejecutaSP_NonQuery(string nombre_sp, List<SqlParameter> lista)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            if (lista != null)
            {
                command.Parameters.AddRange(lista.ToArray());
            }
            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();

            return resultado > 0;
        }
    }
}