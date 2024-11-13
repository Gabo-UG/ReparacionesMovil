using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Interface
{
    public class InterfaceNegocio
    {
        private ManageData obj = new ManageData();

        // Usuario
        public DataTable ObtenerUsuarios()
        {
            return obj.ejecutaSP_Query("ObtenerUsuarios", null);
        }

        public DataTable ObtenerUsuarioPorID(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerUsuarioPorID", parametros);
        }

        public bool InsertarUsuario(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarUsuario", parametros);
        }

        public bool ActualizarUsuario(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarUsuario", parametros);
        }

        public bool EliminarUsuario(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarUsuario", parametros);
        }

        // Cliente
        public DataTable ObtenerClientes()
        {
            return obj.ejecutaSP_Query("ObtenerClientes", null);
        }

        public DataTable ObtenerClientePorID(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerClientePorID", parametros);
        }

        public bool InsertarCliente(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarCliente", parametros);
        }

        public bool ActualizarCliente(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarCliente", parametros);
        }

        public bool EliminarCliente(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarCliente", parametros);
        }

        // Tecnico
        public DataTable ObtenerTecnicos()
        {
            return obj.ejecutaSP_Query("ObtenerTecnicos", null);
        }

        public DataTable ObtenerTecnicoPorID(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerTecnicoPorID", parametros);
        }

        public bool InsertarTecnico(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarTecnico", parametros);
        }

        public bool ActualizarTecnico(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarTecnico", parametros);
        }

        public bool EliminarTecnico(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarTecnico", parametros);
        }

        // Equipo
        public DataTable ObtenerEquipos()
        {
            return obj.ejecutaSP_Query("ObtenerEquipos", null);
        }

        public DataTable ObtenerEquipoPorNumeroSerie(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerEquipoPorNumeroSerie", parametros);
        }

        public DataTable ObtenerEquiposPorCliente(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerEquiposPorCliente", parametros);
        }

        public DataTable ObtenerEquipoPorCorreo(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerEquipoPorCorreo", parametros);
        }

        public bool InsertarEquipo(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarEquipo", parametros);
        }

        public bool ActualizarEquipo(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarEquipo", parametros);
        }

        public bool EliminarEquipo(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarEquipo", parametros);
        }

        // Servicio
        public DataTable ObtenerServicios()
        {
            return obj.ejecutaSP_Query("ObtenerServicios", null);
        }

        public DataTable ObtenerServicioPorID(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerServicioPorID", parametros);
        }

        public bool InsertarServicio(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarServicio", parametros);
        }

        public bool ActualizarServicio(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarServicio", parametros);
        }

        public bool EliminarServicio(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarServicio", parametros);
        }

        // Repuesto
        public DataTable ObtenerRepuestos()
        {
            return obj.ejecutaSP_Query("ObtenerRepuestos", null);
        }

        public DataTable ObtenerRepuestoPorID(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ObtenerRepuestoPorID", parametros);
        }

        public bool InsertarRepuesto(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarRepuesto", parametros);
        }

        public bool ActualizarRepuesto(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarRepuesto", parametros);
        }

        public bool EliminarRepuesto(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarRepuesto", parametros);
        }

        // Reparacion
        public DataTable ObtenerReparaciones()
        {
            return obj.ejecutaSP_Query("ConsultarTodasLasReparaciones", null);
        }

        public DataTable ObtenerReparacionPorID(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_Query("ConsultarReparacion", parametros);
        }

        public bool InsertarReparacionConDetalles(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("InsertarReparacionConDetalles", parametros);
        }

        public bool ActualizarReparacion(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("ActualizarReparacion", parametros);
        }

        public bool EliminarReparacion(List<SqlParameter> parametros)
        {
            return obj.ejecutaSP_NonQuery("EliminarReparacion", parametros);
        }
    }
}
