using Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Equipo
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estado { get; set; }
        public int ClienteId { get; set; }

        public Equipo() { }

        public DataTable ObtenerEquipos()
        {
            return obj.ObtenerEquipos();
        }

        public DataTable ObtenerEquipoPorNumeroSerie(string numeroSerie)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@NumeroSerie", SqlDbType.NVarChar, 100) { Value = numeroSerie },
            };

            return obj.ObtenerEquipoPorNumeroSerie(parametros);
        }

        public DataTable ObtenerEquiposPorCliente(int clienteId)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = clienteId },
            };

            return obj.ObtenerEquiposPorCliente(parametros);
        }

        
        public DataTable ObtenerEquipoPorCorreo(string correo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = correo },
            };

            return obj.ObtenerEquipoPorCorreo(parametros);
        }

        public bool InsertarEquipo()
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Tipo", SqlDbType.NVarChar, 100) { Value = Tipo },
                new SqlParameter("@NumeroSerie", SqlDbType.NVarChar, 100) { Value = NumeroSerie },
                new SqlParameter("@FechaIngreso", SqlDbType.DateTime) { Value = FechaIngreso },
                new SqlParameter("@Estado", SqlDbType.NVarChar, 50) { Value = Estado },
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = ClienteId },
            };

            return obj.InsertarEquipo(parametros);
        }

        public bool ActualizarEquipo(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@EquipoID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Tipo", SqlDbType.NVarChar, 100) { Value = Tipo },
                new SqlParameter("@NumeroSerie", SqlDbType.NVarChar, 100) { Value = NumeroSerie },
                new SqlParameter("@FechaIngreso", SqlDbType.DateTime) { Value = FechaIngreso },
                new SqlParameter("@Estado", SqlDbType.NVarChar, 50) { Value = Estado },
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = ClienteId },
            };

            return obj.ActualizarEquipo(parametros);
        }

        public bool EliminarEquipo(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@EquipoID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarEquipo(parametros);
        }
    }
}
