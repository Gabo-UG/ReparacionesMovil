using Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Servicio : Item
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public string Categoria { get; set; }

        public override DataTable ObtenerItems()
        {
            return obj.ObtenerServicios();
        }

        public override DataTable ObtenerItemPorID(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ServicioID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerServicioPorID(parametros);
        }

        public override bool InsertarItem()
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Categoria", SqlDbType.NVarChar, 100) { Value = Categoria },
                new SqlParameter("@Codigo", SqlDbType.NVarChar, 50) { Value = Codigo },
                new SqlParameter("@Precio", SqlDbType.Decimal) { Value = Precio },
                new SqlParameter("@Iva", SqlDbType.Decimal) { Value = Iva },
                new SqlParameter("@Total", SqlDbType.Decimal) { Value = Total }
            };

            return obj.InsertarServicio(parametros);
        }

        public override bool ActualizarItem(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ServicioID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Categoria", SqlDbType.NVarChar, 100) { Value = Categoria },
                new SqlParameter("@Codigo", SqlDbType.NVarChar, 50) { Value = Codigo },
                new SqlParameter("@Precio", SqlDbType.Decimal) { Value = Precio },
                new SqlParameter("@Iva", SqlDbType.Decimal) { Value = Iva },
                new SqlParameter("@Total", SqlDbType.Decimal) { Value = Total }
            };

            return obj.ActualizarServicio(parametros);
        }

        public override bool EliminarItem(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@ServicioID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarServicio(parametros);
        }

        public override decimal ObtenerCostoItemPorID(int servicioID)
        {
            try
            {
                var parametros = new List<SqlParameter>
                {
                    new SqlParameter("@ServicioID", SqlDbType.Int) { Value = servicioID }
                };

                DataTable dt = obj.ObtenerServicioPorID(parametros);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToDecimal(dt.Rows[0]["Precio"]);
                }
                else
                {
                    throw new Exception("Servicio no encontrado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el costo del servicio: " + ex.Message);
            }
        }
    }
}
