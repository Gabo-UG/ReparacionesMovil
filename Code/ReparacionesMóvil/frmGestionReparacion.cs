using Negocio.Entidades;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
using Datos.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ReparacionesMovil;

namespace CapaPresentacion
{
    public partial class frmGestionReparacion : Form
    {
        private InterfaceNegocio negocio = new InterfaceNegocio();

        private frmMenu menu;

        public frmGestionReparacion(frmMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            checkedListBoxRepuesto.ItemCheck += checkedListBoxRepuesto_ItemCheck;
            checkedListBoxServicio.ItemCheck += checkedListBoxServicio_ItemCheck;
        }

        private void frmGestionReparacion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarTecnicos();
            CargarRepuestos();
            CargarServicios();
            CargarReparaciones();
        }

        private void CargarClientes()
        {
            DataTable dt = negocio.ObtenerClientes();
            cbCliente.DataSource = dt;
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "ClienteID";
        }

        private void CargarTecnicos()
        {
            DataTable dt = negocio.ObtenerTecnicos();
            cbTecnico.DataSource = dt;
            cbTecnico.DisplayMember = "Nombre";
            cbTecnico.ValueMember = "TecnicoID";
        }

        private void CargarRepuestos()
        {
            DataTable dt = negocio.ObtenerRepuestos();

            dt.Columns.Add("NombrePrecio", typeof(string), "Nombre + ' - $' + Convert(Precio, 'System.String')");

            checkedListBoxRepuesto.DataSource = dt;
            checkedListBoxRepuesto.DisplayMember = "NombrePrecio";
            checkedListBoxRepuesto.ValueMember = "RepuestoID";
        }

        private void CargarServicios()
        {
            DataTable dt = negocio.ObtenerServicios();

            dt.Columns.Add("NombrePrecio", typeof(string), "Nombre + ' - $' + Convert(Precio, 'System.String')");

            checkedListBoxServicio.DataSource = dt;
            checkedListBoxServicio.DisplayMember = "NombrePrecio";
            checkedListBoxServicio.ValueMember = "ServicioID";
        }



        private void checkedListBoxRepuesto_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate {
                CalcularPrecioTotalRepuestos();
            });
        }

        private void checkedListBoxServicio_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate {
                CalcularPrecioTotalServicios();
            });
        }

        private void CalcularPrecioTotalRepuestos()
        {
            decimal precioTotalRepuestos = 0;
            foreach (DataRowView item in checkedListBoxRepuesto.CheckedItems)
            {
                decimal precio = Convert.ToDecimal(item["Precio"]);
                precioTotalRepuestos += precio;
            }

            // Incluyendo el item actualmente seleccionado o deseleccionado
            for (int i = 0; i < checkedListBoxRepuesto.Items.Count; i++)
            {
                if (checkedListBoxRepuesto.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    decimal precio = Convert.ToDecimal(((DataRowView)checkedListBoxRepuesto.Items[i])["Precio"]);
                    if (checkedListBoxRepuesto.GetItemChecked(i))
                    {
                        precioTotalRepuestos -= precio;
                    }
                    else
                    {
                        precioTotalRepuestos += precio;
                    }
                }
            }

            lbTotalRepuestos.Text = precioTotalRepuestos.ToString("0.00");
            CalcularPrecioTotal();
        }

        private void CalcularPrecioTotalServicios()
        {
            decimal precioTotalServicios = 0;
            foreach (DataRowView item in checkedListBoxServicio.CheckedItems)
            {
                decimal precio = Convert.ToDecimal(item["Precio"]);
                precioTotalServicios += precio;
            }

            // Incluyendo el item actualmente seleccionado o deseleccionado
            for (int i = 0; i < checkedListBoxServicio.Items.Count; i++)
            {
                if (checkedListBoxServicio.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    decimal precio = Convert.ToDecimal(((DataRowView)checkedListBoxServicio.Items[i])["Precio"]);
                    if (checkedListBoxServicio.GetItemChecked(i))
                    {
                        precioTotalServicios -= precio;
                    }
                    else
                    {
                        precioTotalServicios += precio;
                    }
                }
            }

            lbTotalServicios.Text = precioTotalServicios.ToString("0.00");
            CalcularPrecioTotal();
        }


        private void CalcularPrecioTotal()
        {
            decimal precioTotalRepuestos = Convert.ToDecimal(lbTotalRepuestos.Text);
            decimal precioTotalServicios = Convert.ToDecimal(lbTotalServicios.Text);
            decimal precioTotal = precioTotalRepuestos + precioTotalServicios;
            decimal iva = precioTotal * 0.12M; // Suponiendo un IVA del 12%
            decimal precioTotalConIVA = precioTotal + iva;
            lbTotalReparacion.Text = precioTotalConIVA.ToString("0.00");
            lbTotalIVA.Text = iva.ToString("0.00");
        }


        private void CargarEquipos()
        {
            if (cbCliente.SelectedValue != null)
            {
                int clienteID = Convert.ToInt32(((DataRowView)cbCliente.SelectedItem)["ClienteID"]);

                List<SqlParameter> parametros = new List<SqlParameter>
                {
                    new SqlParameter("@ClienteID", clienteID)
                };
                DataTable dt = negocio.ObtenerEquiposPorCliente(parametros);
                cbEquipo.DataSource = dt;
                cbEquipo.DisplayMember = "NumeroSerie";
                cbEquipo.ValueMember = "EquipoID";
            }
        }

        
        private void CargarReparaciones()
        {
            DataTable dt = negocio.ObtenerReparaciones();
            dgvReparacion.DataSource = dt;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
{
    if (checkedListBoxRepuesto.CheckedItems.Count == 0)
    {
        MessageBox.Show("Debe seleccionar al menos un repuesto.");
        return;
    }

    int clienteID = Convert.ToInt32(cbCliente.SelectedValue);
    int equipoID = Convert.ToInt32(cbEquipo.SelectedValue);
    int tecnicoID = Convert.ToInt32(cbTecnico.SelectedValue);
    string diagnostico = richTextBoxDiagnosticos.Text;
    DateTime fechaIngreso = dateTimePicker1.Value;
    DateTime fechaEntrega = dateTimePicker2.Value;
    decimal costoTotal = CalcularCostoTotal();
    string repuestosDetalle = ObtenerRepuestosDetalle();
    string serviciosDetalle = ObtenerServiciosDetalle();

    List<SqlParameter> parametros = new List<SqlParameter>
    {
        new SqlParameter("@ClienteID", clienteID),
        new SqlParameter("@EquipoID", equipoID),
        new SqlParameter("@TecnicoID", tecnicoID),
        new SqlParameter("@Diagnostico", diagnostico),
        new SqlParameter("@FechaIngreso", fechaIngreso),
        new SqlParameter("@FechaEntrega", fechaEntrega),
        new SqlParameter("@CostoTotal", costoTotal),
        new SqlParameter("@RepuestosDetalle", repuestosDetalle),
        new SqlParameter("@ServiciosDetalle", serviciosDetalle)
    };

    bool resultado = negocio.InsertarReparacionConDetalles(parametros);

    if (resultado)
    {
        MessageBox.Show("Reparación guardada exitosamente.");
        LimpiarFormulario();
        CargarReparaciones();
    }
    else
    {
        MessageBox.Show("Error al guardar la reparación.");
    }
}


        private decimal CalcularCostoTotal()
        {
            decimal costoTotal = 0;

            // Calcular costo de repuestos
            foreach (DataRowView item in checkedListBoxRepuesto.CheckedItems)
            {
                int repuestoID = Convert.ToInt32(item["RepuestoID"]);
                decimal precio = Convert.ToDecimal(item["Precio"]);
                costoTotal += precio;
            }

            // Calcular costo de servicios
            foreach (DataRowView item in checkedListBoxServicio.CheckedItems)
            {
                decimal precio = Convert.ToDecimal(item["Precio"]);
                costoTotal += precio;
            }

            return costoTotal;
        }

        private string ObtenerRepuestosDetalle()
        {
            var repuestos = checkedListBoxRepuesto.CheckedItems.Cast<DataRowView>()
                .Select(item => Convert.ToInt32(item["RepuestoID"]))
                .ToList();

            return Newtonsoft.Json.JsonConvert.SerializeObject(repuestos);
        }

        private string ObtenerServiciosDetalle()
        {
            var servicios = checkedListBoxServicio.CheckedItems.Cast<DataRowView>()
                .Select(item => Convert.ToInt32(item["ServicioID"]))
                .ToList();

            return Newtonsoft.Json.JsonConvert.SerializeObject(servicios);
        }


        private void LimpiarFormulario()
        {
            cbCliente.SelectedIndex = -1;
            cbEquipo.SelectedIndex = -1;
            cbTecnico.SelectedIndex = -1;
            richTextBoxDiagnosticos.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            for (int i = 0; i < checkedListBoxRepuesto.Items.Count; i++)
            {
                checkedListBoxRepuesto.SetItemChecked(i, false);
            }

            for (int i = 0; i < checkedListBoxServicio.Items.Count; i++)
            {
                checkedListBoxServicio.SetItemChecked(i, false);
            }
        }

        private void btnAddClientelpanel_Click(object sender, EventArgs e)
        {
            menu?.MostrarVista(menu.cliente);
        }

        private void AddEquipopanel_Click(object sender, EventArgs e)
        {
            menu?.MostrarVista(menu.equipos);
        }

        private void AddTecnicopanel_Click(object sender, EventArgs e)
        {
            menu?.MostrarVista(menu.tecnico);
        }

        private void btnNuevaReparacion_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

    }
}
