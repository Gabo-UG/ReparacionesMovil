using Datos.Interface;
using Negocio.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    public partial class frmGestionCliente : Form
    {
        private Cliente cliente;
        private bool esNuevo = false;
        private int clienteId = -1;

        public frmGestionCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void frmGestionCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
            AgregarBotones();
        }

        private void AgregarBotones()
        {
            
            if (dgvClientes.Columns["btnEditar"] == null)
            {
                DataGridViewButtonColumn btnEditarColumn = new DataGridViewButtonColumn
                {
                    Name = "btnEditar",
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dgvClientes.Columns.Add(btnEditarColumn);
            }

            if (dgvClientes.Columns["btnEliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminarColumn = new DataGridViewButtonColumn
                {
                    Name = "btnEliminar",
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dgvClientes.Columns.Add(btnEliminarColumn);
            }
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = cliente.ObtenerClientes();
            LimpiarCampos();
            EstablecerModoInicial();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void EstablecerModoInicial()
        {
            btnNuevoRegistroCliente.Enabled = true;
            btnGuardarResgistroCliente.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelarRegistroCliente.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarCampos();
            btnNuevoRegistroCliente.Enabled = false;
            btnGuardarResgistroCliente.Enabled = true;
            btnCancelarRegistroCliente.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Correo = txtCorreo.Text;

                bool resultado = GuardarCliente();

                if (resultado)
                {
                    CargarClientes();
                }

                EstablecerModoInicial();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private bool GuardarCliente()
        {
            bool resultado = false;

            if (esNuevo)
            {
                resultado = cliente.InsertarCliente();
                if (resultado)
                {
                    MessageBox.Show("Cliente registrado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el cliente.");
                }
            }
            else
            {
                resultado = cliente.ActualizarCliente(clienteId);
                if (resultado)
                {
                    MessageBox.Show("Cliente actualizado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }

            return resultado;
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtCorreo.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvClientes.SelectedRows[0];
                EliminarCliente(fila);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstablecerModoInicial();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvClientes.Columns["btnEditar"].Index)
                {
                    CargarDatosCliente(fila);
                }
                else if (e.ColumnIndex == dgvClientes.Columns["btnEliminar"].Index)
                {
                    EliminarCliente(fila);
                }
            }
        }

        private void CargarDatosCliente(DataGridViewRow fila)
        {
            clienteId = Convert.ToInt32(fila.Cells["clienteId"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();

            esNuevo = false;
            btnGuardarResgistroCliente.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelarRegistroCliente.Visible = true;
        }

        private void EliminarCliente(DataGridViewRow fila)
        {
            int clienteID = Convert.ToInt32(fila.Cells["clienteId"].Value);
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool resultado = cliente.EliminarCliente(clienteID);
                if (resultado)
                {
                    MessageBox.Show("Cliente eliminado exitosamente.");
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.");
                }
            }
        }

    }
}
