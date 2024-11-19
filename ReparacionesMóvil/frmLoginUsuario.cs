
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Entidades;


namespace ReparacionesMovil
{
    public partial class frmLoginUsuario : Form
    {
        public bool IsAuthenticated { get; private set; } = false;
        public frmLoginUsuario()
        {
            InitializeComponent();

            txtUsuario.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txtContrasenia.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            RealizarInicioSesion();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si la tecla presionada es "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                RealizarInicioSesion();
            }
        }
        private void RealizarInicioSesion()
        {
            try
            {
                string nombreUsuario = txtUsuario.Text;
                string contraseña = txtContrasenia.Text;

                // Validar entrada básica
                if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (AutenticarUsuario(nombreUsuario, contraseña))
                {
                    IsAuthenticated = true;
                    frmMenu menuForm = new frmMenu();
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo genérico de errores
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            return nombreUsuario == "adminJ" && contraseña == "jnvj1234"; // Ejemplo básico
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
