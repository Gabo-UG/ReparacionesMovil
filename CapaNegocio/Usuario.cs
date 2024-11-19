using Datos.Interface;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Usuario 
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public string Rol { get; set; }
        public string Credenciales { get; set; }
        
        public Usuario() { }

        public DataTable ObtenerUsuarios()
        {
            return obj.ObtenerUsuarios();
        }

        public DataTable ObtenerUsuarioPorID(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@UsuarioID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerUsuarioPorID(parametros);
        }

        public bool InsertarUsuario()
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Rol", SqlDbType.NVarChar, 50) { Value = Rol },
                new SqlParameter("@Credenciales", SqlDbType.NVarChar, 255) { Value = Credenciales },
            };

            return obj.InsertarUsuario(parametros);
        }

        public bool ActualizarUsuario(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@UsuarioID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Rol", SqlDbType.NVarChar, 50) { Value = Rol },
                new SqlParameter("@Credenciales", SqlDbType.NVarChar, 255) { Value = Credenciales },
            };

            return obj.ActualizarUsuario(parametros);
        }

        public bool EliminarUsuario(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@UsuarioID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarUsuario(parametros);
        }
    }
}
