using Negocio.Entidades;
using System;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    public partial class frmRegistroRepuesto : Form
    {
        private int id;
        private double iva = 0.12;
        private bool isNewItem = false;
        private Repuesto obj_repuesto = new Repuesto();
        private Servicio obj_servicio = new Servicio();

        public frmRegistroRepuesto()
        {
            InitializeComponent();
        }

        private void frmRegistroRepuesto_Load(object sender, EventArgs e)
        {
            cargarRepuesto();
            cargarServicio();
            DeshabilitarCampos();
            DeshabilitarCamposServicio();
        }

        private void cargarRepuesto()
        {
            try
            {
                dgvRepuesto.DataSource = obj_repuesto.ObtenerItems();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al obtener datos de Repuestos");
            }
        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
            HabilitarCampos();
            ToggleButtons(false);
            isNewItem = true;
        }

        private void btnGuardarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                obj_repuesto.Nombre = txtRepuestoNombre.Text;
                obj_repuesto.Codigo = txtRepuestoCodigo.Text;
                obj_repuesto.Precio = decimal.Parse(txtRepuestoPrecio.Text);
                obj_repuesto.Iva = (decimal)iva * obj_repuesto.Precio;
                obj_repuesto.Total = obj_repuesto.Iva + obj_repuesto.Precio;

                bool resultado;
                if (isNewItem)
                {
                    resultado = obj_repuesto.InsertarItem();
                }
                else
                {
                    resultado = obj_repuesto.ActualizarItem(id);
                }

                if (resultado)
                {
                    MessageBox.Show("Operación exitosa.");
                    cargarRepuesto();
                    ToggleButtons(true);
                    isNewItem = false;
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }

                DeshabilitarCampos();
                ReiniciarFormulario();
            }
            catch (FormatException ex)
            {
                LogError(ex);
                MessageBox.Show("Formato incorrecto");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error");
            }
        }

        // Servicios methods

        private void cargarServicio()
        {
            try
            {
                dgvServicio.DataSource = obj_servicio.ObtenerItems();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al obtener datos de Servicios");
            }
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            HabilitarCamposServicio();
            ReiniciarFormularioServicio();
            ToggleButtonsServicio(false);
            isNewItem = true;
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposServicio() || cmbCategoria.Text == "Seleccione")
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                obj_servicio.Nombre = txtServicioNombre.Text;
                obj_servicio.Categoria = cmbCategoria.Text;
                obj_servicio.Codigo = txtServicioCodigo.Text;
                obj_servicio.Precio = decimal.Parse(txtServicioPrecio.Text);
                obj_repuesto.Iva = (decimal)iva * obj_repuesto.Precio;
                obj_servicio.Total = obj_servicio.Iva + obj_servicio.Precio;

                bool resultado;
                if (isNewItem)
                {
                    resultado = obj_servicio.InsertarItem();
                }
                else
                {
                    resultado = obj_servicio.ActualizarItem(id);
                }

                if (resultado)
                {
                    MessageBox.Show("Operación exitosa.");
                    cargarServicio();
                    ToggleButtonsServicio(true);
                    isNewItem = false;
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }

                DeshabilitarCamposServicio();
                ReiniciarFormularioServicio();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error");
            }
        }

        private void LogError(Exception ex)
        {
            // Log the exception here
        }

        private void ToggleButtons(bool isEnabled)
        {
            btnNuevoRepuesto.Visible = isEnabled;
            btnCancelarRepuesto.Visible = !isEnabled;
            btnNuevoRepuesto.Enabled = isEnabled;
            btnGuardarRepuesto.Enabled = !isEnabled;
            btnEliminarRepuesto.Enabled = !isEnabled;
        }

        private void ToggleButtonsServicio(bool isEnabled)
        {
            btnNuevoServicio.Visible = isEnabled;
            btnCancelarServicio.Visible = !isEnabled;
            btnNuevoServicio.Enabled = isEnabled;
            btnGuardarServicio.Enabled = !isEnabled;
            btnEliminarServicio.Enabled = !isEnabled;
        }

        private void DeshabilitarCampos()
        {
            txtRepuestoNombre.Enabled = false;
            txtRepuestoCodigo.Enabled = false;
            txtRepuestoPrecio.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtRepuestoNombre.Enabled = true;
            txtRepuestoCodigo.Enabled = true;
            txtRepuestoPrecio.Enabled = true;
        }

        private void DeshabilitarCamposServicio()
        {
            txtServicioNombre.Enabled = false;
            cmbCategoria.Enabled = false;
            txtServicioCodigo.Enabled = false;
            txtServicioPrecio.Enabled = false;
        }

        private void HabilitarCamposServicio()
        {
            txtServicioNombre.Enabled = true;
            cmbCategoria.Enabled = true;
            txtServicioCodigo.Enabled = true;
            txtServicioPrecio.Enabled = true;
        }

        private void ReiniciarFormulario()
        {
            txtRepuestoNombre.Text = "";
            txtRepuestoCodigo.Text = "";
            txtRepuestoPrecio.Text = "";
        }

        private void ReiniciarFormularioServicio()
        {
            txtServicioNombre.Text = "";
            cmbCategoria.SelectedIndex = 0;
            txtServicioCodigo.Text = "";
            txtServicioPrecio.Text = "";
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrEmpty(txtRepuestoNombre.Text) &&
                   !string.IsNullOrEmpty(txtRepuestoCodigo.Text) &&
                   !string.IsNullOrEmpty(txtRepuestoPrecio.Text);
        }

        private bool ValidarCamposServicio()
        {
            return !string.IsNullOrEmpty(txtServicioNombre.Text) &&
                   !string.IsNullOrEmpty(cmbCategoria.Text) &&
                   !string.IsNullOrEmpty(txtServicioCodigo.Text) &&
                   !string.IsNullOrEmpty(txtServicioPrecio.Text);
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelarRepuesto_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            ReiniciarFormulario();
            ToggleButtons(true);
            isNewItem = false;
        }

        private void btnCancelarServicio_Click(object sender, EventArgs e)
        {
            DeshabilitarCamposServicio();
            ReiniciarFormularioServicio();
            ToggleButtonsServicio(true);
            isNewItem = false;
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar este repuesto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj_repuesto.EliminarItem(id);
                    cargarRepuesto();
                    MessageBox.Show("Repuesto eliminado.");
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al eliminar el repuesto.");
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar este servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj_servicio.EliminarItem(id);
                    cargarServicio();
                    MessageBox.Show("Servicio eliminado.");
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al eliminar el servicio.");
            }
        }

        private void dgvRepuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRepuesto.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["RepuestoID"].Value);
                txtRepuestoNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtRepuestoCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtRepuestoPrecio.Text = row.Cells["Precio"].Value.ToString();

                HabilitarCampos();
                ToggleButtons(false);
            }
        }

        private void dgvServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvServicio.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["ServicioID"].Value);
                txtServicioNombre.Text = row.Cells["Nombre"].Value.ToString();
                cmbCategoria.Text = row.Cells["Categoria"].Value.ToString();
                txtServicioCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtServicioPrecio.Text = row.Cells["Precio"].Value.ToString();

                HabilitarCamposServicio();
                ToggleButtonsServicio(false);
            }
        }
    }
}
