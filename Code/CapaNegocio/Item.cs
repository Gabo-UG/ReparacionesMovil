using Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.Entidades
{
    public abstract class Item
    {
        private InterfaceNegocio obj = new InterfaceNegocio();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }

        public abstract DataTable ObtenerItems();
        public abstract DataTable ObtenerItemPorID(int id);
        public abstract bool InsertarItem();
        public abstract bool ActualizarItem(int id);
        public abstract bool EliminarItem(int id);
        public abstract decimal ObtenerCostoItemPorID(int itemID);
    }
}
