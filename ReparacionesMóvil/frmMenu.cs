using CapaPresentacion;
using ReparacionesMovil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    public partial class frmMenu : Form
    {

        public frmGestionCliente cliente;
        public frmGestionTecnicos tecnico;
        public frmGestionEquipos equipos;
        public frmRegistroRepuesto repuestos;
        protected frmGestionReparacion reparacion;
        //protected frmSeguimiento Seguimiento;


        public frmMenu()
        {
            InitializeComponent();
            cliente = new frmGestionCliente();
            tecnico = new frmGestionTecnicos();
            repuestos = new frmRegistroRepuesto();
            equipos = new frmGestionEquipos();
            reparacion = new frmGestionReparacion(this);
            //Seguimiento = new frmSeguimiento();    

            MostrarVista(reparacion);
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            this.panelSidebar.Visible = !this.panelSidebar.Visible;

            
            if (this.panelSidebar.Visible)
            {
                this.buttonToggle.Location = new Point(150, 3);
            }
            else
            {
                this.buttonToggle.Location = new Point(10, 10);
            }
        }

        public void MostrarVista(Form vista)
        {
            if (!PanelVistas.Controls.Contains(vista))
            {
                vista.TopLevel = false;
                vista.FormBorderStyle = FormBorderStyle.None;
                vista.Dock = DockStyle.Fill;
                PanelVistas.Controls.Add(vista);
                vista.Show();
            }
            vista.BringToFront();
        }

        public void buttonEquipo_Click(object sender, EventArgs e)
        {
            MostrarVista(equipos);
        }

        public void buttonClientes_Click(object sender, EventArgs e)
        {
            MostrarVista(cliente);
        }

        public void buttonTecnico_Click(object sender, EventArgs e)
        {
            MostrarVista(tecnico); 
        }

        private void buttonRepuestos_Click(object sender, EventArgs e)
        {
            MostrarVista(repuestos);
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            MostrarVista(reparacion);
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            //MostrarVista(Seguimiento);
        }
    }
}
