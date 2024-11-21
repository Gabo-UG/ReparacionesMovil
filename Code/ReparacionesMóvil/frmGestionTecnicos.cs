using Negocio.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmGestionTecnicos : Form
    {
        private Tecnico tecnico;
        private bool esNuevo = false;
        private int TecnicoId = -1; 

        public frmGestionTecnicos()
        {
            InitializeComponent();
            tecnico = new Tecnico();
            Load += new System.EventHandler(this.frmGestionTecnico_Load);

        }

        private void frmGestionTecnico_Load(object sender, EventArgs e)
        {
            CargarTecnicos();
            AgregarBotones();
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
            if (dgvTecnicos.Columns["btnEditar"] == null)
            {
                dgvTecnicos.Columns.Add(btnEditarColumn);
            }
            if (dgvTecnicos.Columns["btnEliminar"] == null)
            {
                dgvTecnicos.Columns.Add(btnEliminarColumn);
            }
        }

        private void CargarTecnicos()
        {
            dgvTecnicos.DataSource = tecnico.ObtenerTecnicos();
            DeshabilitarCampos();
            LimpiarCampos();
            EstablecerModoInicial();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            HabilitarCampos();
            LimpiarCampos();
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tecnico.Nombre = txtNombre.Text;
                tecnico.Especialidad = txtEspecialidad.Text;
                tecnico.Telefono = txtTelefono.Text;
                tecnico.Correo = txtCorreo.Text;

                bool resultado = false;

                if (esNuevo)
                {
                    resultado = tecnico.InsertarTecnico();
                    if (resultado)
                    {
                        MessageBox.Show("Técnico registrado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el técnico.");
                    }
                }
                else
                {
                    resultado = tecnico.ActualizarTecnico(TecnicoId);
                    if (resultado)
                    {
                        MessageBox.Show("Técnico actualizado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el técnico.");
                    }
                }

                if (resultado)
                {
                    CargarTecnicos();
                }

                EstablecerModoInicial();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstablecerModoInicial();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TecnicoId != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el técnico seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (tecnico.EliminarTecnico(TecnicoId))
                    {
                        MessageBox.Show("Técnico eliminado exitosamente.");
                        CargarTecnicos();
                        EstablecerModoInicial();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el técnico.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un técnico para eliminar.");
            }
        }

        private void dgvTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HabilitarCampos();
                DataGridViewRow fila = dgvTecnicos.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();

                TecnicoId = Convert.ToInt32(fila.Cells["TecnicoID"].Value);

                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                esNuevo = false;
            }
        }

        private void dgvTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HabilitarCampos();
                DataGridViewRow fila = dgvTecnicos.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvTecnicos.Columns["btnEditar"].Index)
                {
                    // Cargar datos del técnico seleccionado para edición
                    txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                    txtEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
                    txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = fila.Cells["Correo"].Value.ToString();

                    esNuevo = false;
                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Visible = true;
                }
                else if (e.ColumnIndex == dgvTecnicos.Columns["btnEliminar"].Index)
                {
                    // Eliminar el técnico seleccionado
                    int tecnicoID = Convert.ToInt32(fila.Cells["TecnicoID"].Value);
                    if (MessageBox.Show("¿Estás seguro de que deseas eliminar este técnico?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (tecnico.EliminarTecnico(tecnicoID))
                        {
                            MessageBox.Show("Técnico eliminado exitosamente.");
                            CargarTecnicos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el técnico.");
                        }
                    }
                }
            }
        }
        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   !string.IsNullOrWhiteSpace(txtEspecialidad.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtCorreo.Text);
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecialidad.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void EstablecerModoInicial()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Visible = false;
        }

        private void HabilitarCampos()
        {
            txtNombre.Enabled = true;
            txtEspecialidad.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
        }
        private void DeshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtEspecialidad.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
