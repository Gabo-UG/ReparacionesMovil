using Datos.Interface;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Cliente : Persona
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public string Direccion { get; set; }

        public Cliente() { }

        public DataTable ObtenerClientes()
        {
            return obj.ObtenerClientes();
        }

        public bool InsertarCliente()
        {
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
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Direccion", SqlDbType.NVarChar, 100) { Value = Direccion },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = Telefono },
                new SqlParameter("@Correo", SqlDbType.NVarChar, 100) { Value = Correo },
            };

            return obj.ActualizarCliente(parametros);
        }

        public bool EliminarCliente(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarCliente(parametros);
        }
        public DataTable ObtenerClientePorID(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerClientePorID(parametros);
        }
    }
}
