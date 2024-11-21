using Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Reparacion
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EquipoId { get; set; }
        public int TecnicoId { get; set; }
        public string Diagnostico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal CostoTotal { get; set; }
        public List<Repuesto> Repuestos { get; set; }
        public List<Servicio> Servicios { get; set; }

        public Reparacion()
        {
            Repuestos = new List<Repuesto>();
            Servicios = new List<Servicio>();
        }

        public DataTable ObtenerReparaciones()
        {
            return obj.ObtenerReparaciones();
        }

        public DataTable ObtenerReparacionPorID(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ReparacionID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerReparacionPorID(parametros);
        }

        public bool InsertarReparacionConDetalles()
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = ClienteId },
                new SqlParameter("@EquipoID", SqlDbType.Int) { Value = EquipoId },
                new SqlParameter("@TecnicoID", SqlDbType.Int) { Value = TecnicoId },
                new SqlParameter("@Diagnostico", SqlDbType.NVarChar) { Value = Diagnostico },
                new SqlParameter("@FechaIngreso", SqlDbType.DateTime) { Value = FechaIngreso },
                new SqlParameter("@FechaEntrega", SqlDbType.DateTime) { Value = FechaEntrega },
                new SqlParameter("@CostoTotal", SqlDbType.Decimal) { Value = CostoTotal },
                new SqlParameter("@RepuestosDetalle", SqlDbType.NVarChar) { Value = ObtenerRepuestosDetalle() },
                new SqlParameter("@ServiciosDetalle", SqlDbType.NVarChar) { Value = ObtenerServiciosDetalle() }
            };

            return obj.InsertarReparacionConDetalles(parametros);
        }

        public bool ActualizarReparacion(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ReparacionID", SqlDbType.Int) { Value = id },
                new SqlParameter("@ClienteID", SqlDbType.Int) { Value = ClienteId },
                new SqlParameter("@EquipoID", SqlDbType.Int) { Value = EquipoId },
                new SqlParameter("@TecnicoID", SqlDbType.Int) { Value = TecnicoId },
                new SqlParameter("@Diagnostico", SqlDbType.NVarChar) { Value = Diagnostico },
                new SqlParameter("@FechaIngreso", SqlDbType.DateTime) { Value = FechaIngreso },
                new SqlParameter("@FechaEntrega", SqlDbType.DateTime) { Value = FechaEntrega },
                new SqlParameter("@CostoTotal", SqlDbType.Decimal) { Value = CostoTotal }
            };

            return obj.ActualizarReparacion(parametros);
        }

        public bool EliminarReparacion(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ReparacionID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarReparacion(parametros);
        }

        private string ObtenerRepuestosDetalle()
        {
            var detalles = new List<string>();
            foreach (var repuesto in Repuestos)
            {
                detalles.Add($"{{ \"ItemID\": {repuesto.Id} }}");
            }
            return $"[{string.Join(",", detalles)}]";
        }


        private string ObtenerServiciosDetalle()
        {
            var detalles = new List<string>();
            foreach (var servicio in Servicios)
            {
                detalles.Add($"{{ \"ItemID\": {servicio.Id} }}");
            }
            return $"[{string.Join(",", detalles)}]";
        }
    }
}
