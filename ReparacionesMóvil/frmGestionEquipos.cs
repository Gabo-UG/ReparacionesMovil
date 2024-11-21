using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmGestionEquipos : Form
    {
        // Instancia de la clase Equipo para manejar las operaciones relacionadas con los equipos.
        private Equipo equipo;
        private bool esNuevo = false;  // Bandera para indicar si se está creando un nuevo equipo.
        private int equipoID = -1;
        public frmGestionEquipos()
        {
            InitializeComponent();
            equipo = new Equipo();

        }
        private void frmGestionEquipos_Load(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarClientes();
            AgregarBotones();
        }


        private void CargarClientes()
        {

            DataTable clientes = new Negocio.Entidades.Cliente().ObtenerClientes();

            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ClienteID";
        }


        private void AgregarBotones()
        {
            // Crear columnas de botones
            DataGridViewButtonColumn btnEditarColumn = new DataGridViewButtonColumn
            {
                Name = "btnEditar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 80
            };

            DataGridViewButtonColumn btnEliminarColumn = new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            };

            // Agregar columnas al DataGridView
            if (dgvEquipos.Columns["btnEditar"] == null)
            {
                dgvEquipos.Columns.Add(btnEditarColumn);
            }
            if (dgvEquipos.Columns["btnEliminar"] == null)
            {
                dgvEquipos.Columns.Add(btnEliminarColumn);
            }
        }

        private void CargarEquipos()
        {
            // Carga los datos de los equipos desde la capa de negocio al DataGridView.
            dgvEquipos.DataSource = equipo.ObtenerEquipos();
            LimpiarCampos();
            EstablecerModoInicial();
        }

        private void LimpiarCampos()
        {

            txtSerie.Clear();
            txtTipo.Clear();
            cmbEstado.SelectedIndex = 0;  // Restablece el ComboBox al valor inicial.
            dateIngreso.Value = DateTime.Now;
        }

        private void EstablecerModoInicial()
        {
            btnNuevoEquipo.Enabled = true;
            btnGuardarEquipo.Enabled = false;
            btnCancelarEquipo.Visible = false;
        }

        private bool ValidarCampos()
        {
            // Valida los campos del formulario antes de guardar o actualizar.
            bool esValido = true;
            StringBuilder mensajeError = new StringBuilder();

            try
            {
                if (string.IsNullOrWhiteSpace(txtSerie.Text) || !Regex.IsMatch(txtSerie.Text, @"^[A-Z0-9]+$"))
                {
                    esValido = false;
                    mensajeError.AppendLine("El campo 'Número de Serie' está vacío o contiene caracteres no válidos (solo se permiten letras mayúsculas y números)");
                }

                if (string.IsNullOrWhiteSpace(txtTipo.Text) || !Regex.IsMatch(txtTipo.Text, @"^[a-zA-Z]+$"))
                {
                    esValido = false;
                    mensajeError.AppendLine("El campo 'Tipo' está vacío o contiene caracteres no válidos (solo se permiten letras)");
                }

            if (cmbEstado.Text == "Seleccione")
            {
                esValido = false;
                mensajeError.AppendLine("No has seleccionado el campo estado");
            }

                if (dateIngreso.Value == DateTime.MinValue)
                {
                    esValido = false;
                    mensajeError.AppendLine("El campo 'Fecha de Ingreso' no está establecido.");
                }

                if (cbClientes.SelectedValue == null)
                {
                    esValido = false;
                    mensajeError.AppendLine("No se ha seleccionado un cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar campos: " + ex.Message);
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(mensajeError.ToString(), "Campos incompletos");
            }

            return esValido;

        }


        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejo de clics en las columnas de botones del DataGridView.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEquipos.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvEquipos.Columns["btnEditar"].Index)
                {
                    // Cargar datos del equipo seleccionado en el formulario para editar.
                    txtTipo.Text = fila.Cells["Tipo"].Value.ToString();
                    txtSerie.Text = fila.Cells["NumeroSerie"].Value.ToString();
                    string estado = fila.Cells["Estado"].Value.ToString();
                    cmbEstado.SelectedItem = estado;
                    if (fila.Cells["FechaIngreso"].Value != null && DateTime.TryParse(fila.Cells["FechaIngreso"].Value.ToString(), out DateTime fecha))
                    {
                        dateIngreso.Value = fecha;
                    }
                    else
                    {
                        dateIngreso.Value = DateTime.Now;
                    }

                    equipoID = Convert.ToInt32(fila.Cells["EquipoID"].Value);

                    esNuevo = false;
                    btnGuardarEquipo.Enabled = true;
                    btnCancelarEquipo.Visible = true;
                }
                else if (e.ColumnIndex == dgvEquipos.Columns["btnEliminar"].Index)
                {
                    int equipoID = Convert.ToInt32(fila.Cells["EquipoID"].Value);
                    if (MessageBox.Show("¿Estás seguro de que deseas eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (equipo.EliminarEquipo(equipoID))
                        {
                            MessageBox.Show("Equipo eliminado exitosamente.");
                            CargarEquipos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el equipo.");
                        }
                    }
                }

            }
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEquipos.Rows[e.RowIndex];
                txtTipo.Text = fila.Cells["Tipo"].Value.ToString();
                txtSerie.Text = fila.Cells["NumeroSerie"].Value.ToString();
                string estado = fila.Cells["Estado"].Value.ToString();
                cmbEstado.SelectedItem = estado;
                if (fila.Cells["FechaIngreso"].Value != null && DateTime.TryParse(fila.Cells["FechaIngreso"].Value.ToString(), out DateTime fecha))
                {
                    dateIngreso.Value = fecha;
                }
                else
                {
                    dateIngreso.Value = DateTime.Now;
                }

                equipoID = Convert.ToInt32(fila.Cells["EquipoID"].Value);

                btnGuardarEquipo.Enabled = true;
                esNuevo = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstablecerModoInicial();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (equipoID != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el equipo seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (equipo.EliminarEquipo(equipoID))
                    {
                        MessageBox.Show("Equipo eliminado exitosamente.");
                        CargarEquipos();
                        EstablecerModoInicial();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el equipo.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un equipo para eliminar.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                esNuevo = true;
                LimpiarCampos();
                btnNuevoEquipo.Enabled = false;
                btnGuardarEquipo.Enabled = true;
                btnCancelarEquipo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear un nuevo equipo: " + ex.Message);
            }
        }

        private void btnGuardarEquipo_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validación y guardado de los datos del equipo.

                if (ValidarCampos())
                {
                    equipo.NumeroSerie = txtSerie.Text;
                    equipo.Tipo = txtTipo.Text;
                    equipo.Estado = cmbEstado.Text;
                    equipo.FechaIngreso = dateIngreso.Value;
                    equipo.ClienteId = Convert.ToInt32(cbClientes.SelectedValue);

                    bool resultado = false;

                    if (esNuevo)
                    {
                        resultado = equipo.InsertarEquipo();
                        if (resultado)
                        {
                            MessageBox.Show("Equipo registrado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el equipo.");
                        }
                    }
                    else
                    {
                        resultado = equipo.ActualizarEquipo(equipoID);
                        if (resultado)
                        {
                            MessageBox.Show("Equipo actualizado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el equipo.");
                        }
                    }

                    if (resultado)
                    {
                        CargarEquipos();
                    }
                    EstablecerModoInicial();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la base de datos al guardar el equipo: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el equipo: " + ex.Message);
            }
        }
    }
}


