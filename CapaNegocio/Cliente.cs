using Datos.Interface;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    // Clase Cliente que hereda de Persona
    public class Cliente : Persona
    {
        // Objeto para interactuar con la capa de negocio
        private InterfaceNegocio obj = new InterfaceNegocio();
        public string Direccion { get; set; }

        public Cliente() { }

        public DataTable ObtenerClientes()
        {
            return obj.ObtenerClientes();
        }

        public bool InsertarCliente()
        {
            // Crear una lista de parámetros para enviar al procedimiento almacenado
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Direccion", SqlDbType.NVarChar, 100) { Value = Direccion },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = Telefono },
                new SqlParameter("@Correo", SqlDbType.NVarChar, 100) { Value = Correo },
            };

            return obj.InsertarCliente(parametros);
        }

        public bool ActualizarCliente(int id)
        {
            // Crear una lista de parámetros para actualizar los datos del cliente
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Direccion", SqlDbType.NVarChar, 100) { Value = Direccion },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = Telefono },
                new SqlParameter("@Correo", SqlDbType.NVarChar, 100) { Value = Correo },
            };

            // Llamar al método de la capa de negocio para actualizar el cliente
            return obj.ActualizarCliente(parametros);
        }

        public bool EliminarCliente(int id)
        {
            // Crear una lista de parámetros con el ID del cliente a eliminar
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarCliente(parametros);
        }
        public DataTable ObtenerClientePorID(int id)
        {
            // Crear una lista de parámetros con el ID del cliente
            List<SqlParameter> parametros= new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerClientePorID(parametros);
        }
    }
}
