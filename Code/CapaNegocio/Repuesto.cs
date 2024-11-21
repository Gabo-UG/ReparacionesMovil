using Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public class Repuesto : Item
    {
        private InterfaceNegocio obj = new InterfaceNegocio();

        public override DataTable ObtenerItems()
        {
            return obj.ObtenerRepuestos();
        }

        public override DataTable ObtenerItemPorID(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@RepuestoID", SqlDbType.Int) { Value = id },
            };

            return obj.ObtenerRepuestoPorID(parametros);
        }

        public override bool InsertarItem()
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Codigo", SqlDbType.NVarChar, 50) { Value = Codigo },
                new SqlParameter("@Precio", SqlDbType.Decimal) { Value = Precio },
                new SqlParameter("@Iva", SqlDbType.Decimal) { Value = Iva },
                new SqlParameter("@Total", SqlDbType.Decimal) { Value = Total }
            };

            return obj.InsertarRepuesto(parametros);
        }

        public override bool ActualizarItem(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@RepuestoID", SqlDbType.Int) { Value = id },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 100) { Value = Nombre },
                new SqlParameter("@Codigo", SqlDbType.NVarChar, 50) { Value = Codigo },
                new SqlParameter("@Precio", SqlDbType.Decimal) { Value = Precio },
                new SqlParameter("@Iva", SqlDbType.Decimal) { Value = Iva },
                new SqlParameter("@Total", SqlDbType.Decimal) { Value = Total }
            };

            return obj.ActualizarRepuesto(parametros);
        }

        public override bool EliminarItem(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@RepuestoID", SqlDbType.Int) { Value = id },
            };

            return obj.EliminarRepuesto(parametros);
        }

        public override decimal ObtenerCostoItemPorID(int repuestoID)
        {
            try
            {
                var parametros = new List<SqlParameter>
                {
                    new SqlParameter("@RepuestoID", SqlDbType.Int) { Value = repuestoID }
                };

                DataTable dt = obj.ObtenerRepuestoPorID(parametros);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToDecimal(dt.Rows[0]["Precio"]);
                }
                else
                {
                    throw new Exception("Repuesto no encontrado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el costo del repuesto: " + ex.Message);
            }
        }
    }
}
