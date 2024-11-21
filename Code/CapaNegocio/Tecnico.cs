using Datos.Interface;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Tecnico : Persona
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public string Especialidad { get; set; }

        public Tecnico() { }

        public DataTable ObtenerTecnicos()
        {
            return obj.ObtenerTecnicos();
        }

        public DataTable ObtenerTecnicoPorID(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@TecnicoID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerTecnicoPorID(parametros);
        }

        public bool InsertarTecnico()
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Especialidad", SqlDbType.NVarChar, 100) { Value = Especialidad },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = Telefono },
                new SqlParameter("@Correo", SqlDbType.NVarChar, 100) { Value = Correo },
            };

            return obj.InsertarTecnico(parametros);
        }

        public bool ActualizarTecnico(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@TecnicoID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Especialidad", SqlDbType.NVarChar, 100) { Value = Especialidad },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = Telefono },
                new SqlParameter("@Correo", SqlDbType.NVarChar, 100) { Value = Correo },
            };

            return obj.ActualizarTecnico(parametros);
        }

        public bool EliminarTecnico(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@TecnicoID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarTecnico(parametros);
        }
    }
}

