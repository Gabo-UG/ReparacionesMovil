using Datos.Interface;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Usuario 
    {
        // Objeto de la capa de negocio para interactuar con la base de datos.
        private InterfaceNegocio obj = new InterfaceNegocio();
        public string Rol { get; set; }

        // Propiedad para las credenciales del usuario
        public string Credenciales { get; set; }
        
        public Usuario() { }

        public DataTable ObtenerUsuarios()
        {
            return obj.ObtenerUsuarios();
        }

        public DataTable ObtenerUsuarioPorID(int id)
        {
            // Crear lista de parámetros para el procedimiento almacenado o consulta SQL.
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@UsuarioID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerUsuarioPorID(parametros);
        }

        public bool InsertarUsuario()
        {
            // Crear lista de parámetros con los datos necesarios para el usuario.
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Rol", SqlDbType.NVarChar, 50) { Value = Rol },
                new SqlParameter("@Credenciales", SqlDbType.NVarChar, 255) { Value = Credenciales },
            };

            return obj.InsertarUsuario(parametros);
        }

        public bool ActualizarUsuario(int id)
        {
            // Crear lista de parámetros con los datos actualizados del usuario.
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
            // Crear lista de parámetros con el ID del usuario a eliminar.
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@UsuarioID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarUsuario(parametros);
        }
    }
}
