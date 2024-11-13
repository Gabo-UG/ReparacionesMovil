using System.Drawing;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    partial class frmMenu : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            btnSeguimiento = new Button();
            buttonTecnico = new Button();
            buttonClientes = new Button();
            buttonEquipo = new Button();
            buttonRepuestos = new Button();
            btnReparacion = new Button();
            buttonToggle = new Button();
            PanelBase = new Panel();
            PanelVistas = new Panel();
            panelSidebar.SuspendLayout();
            PanelBase.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(13, 13, 13);
            panelSidebar.Controls.Add(btnSeguimiento);
            panelSidebar.Controls.Add(buttonTecnico);
            panelSidebar.Controls.Add(buttonClientes);
            panelSidebar.Controls.Add(buttonEquipo);
            panelSidebar.Controls.Add(buttonRepuestos);
            panelSidebar.Controls.Add(btnReparacion);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(144, 667);
            panelSidebar.TabIndex = 0;
            // 
            // btnSeguimiento
            // 
            btnSeguimiento.BackColor = Color.FromArgb(60, 60, 60);
            btnSeguimiento.FlatStyle = FlatStyle.Flat;
            btnSeguimiento.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnSeguimiento.ForeColor = Color.White;
            btnSeguimiento.Location = new Point(9, 185);
            btnSeguimiento.Name = "btnSeguimiento";
            btnSeguimiento.Size = new Size(127, 26);
            btnSeguimiento.TabIndex = 5;
            btnSeguimiento.Text = "Seguimiento";
            btnSeguimiento.TextAlign = ContentAlignment.BottomCenter;
            btnSeguimiento.UseVisualStyleBackColor = false;
            btnSeguimiento.Click += btnSeguimiento_Click;
            // 
            // buttonTecnico
            // 
            buttonTecnico.BackColor = Color.FromArgb(60, 60, 60);
            buttonTecnico.FlatStyle = FlatStyle.Flat;
            buttonTecnico.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonTecnico.ForeColor = Color.White;
            buttonTecnico.Location = new Point(9, 90);
            buttonTecnico.Name = "buttonTecnico";
            buttonTecnico.Size = new Size(127, 26);
            buttonTecnico.TabIndex = 4;
            buttonTecnico.Text = "Tecnico";
            buttonTecnico.UseVisualStyleBackColor = false;
            buttonTecnico.Click += buttonTecnico_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.BackColor = Color.FromArgb(60, 60, 60);
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonClientes.ForeColor = Color.White;
            buttonClientes.Location = new Point(9, 26);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(127, 26);
            buttonClientes.TabIndex = 0;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = false;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonEquipo
            // 
            buttonEquipo.BackColor = Color.FromArgb(60, 60, 60);
            buttonEquipo.FlatStyle = FlatStyle.Flat;
            buttonEquipo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonEquipo.ForeColor = Color.White;
            buttonEquipo.Location = new Point(9, 58);
            buttonEquipo.Name = "buttonEquipo";
            buttonEquipo.Size = new Size(127, 26);
            buttonEquipo.TabIndex = 1;
            buttonEquipo.Text = "Equipo";
            buttonEquipo.UseVisualStyleBackColor = false;
            buttonEquipo.Click += buttonEquipo_Click;
            // 
            // buttonRepuestos
            // 
            buttonRepuestos.BackColor = Color.FromArgb(60, 60, 60);
            buttonRepuestos.FlatStyle = FlatStyle.Flat;
            buttonRepuestos.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonRepuestos.ForeColor = Color.White;
            buttonRepuestos.Location = new Point(9, 122);
            buttonRepuestos.Name = "buttonRepuestos";
            buttonRepuestos.Size = new Size(127, 26);
            buttonRepuestos.TabIndex = 2;
            buttonRepuestos.Text = "Repuesto";
            buttonRepuestos.UseVisualStyleBackColor = false;
            buttonRepuestos.Click += buttonRepuestos_Click;
            // 
            // btnReparacion
            // 
            btnReparacion.BackColor = Color.FromArgb(60, 60, 60);
            btnReparacion.FlatStyle = FlatStyle.Flat;
            btnReparacion.Font = new Font("Consolas", 9F, FontStyle.Bold);
            btnReparacion.ForeColor = Color.White;
            btnReparacion.Location = new Point(9, 153);
            btnReparacion.Name = "btnReparacion";
            btnReparacion.Size = new Size(127, 26);
            btnReparacion.TabIndex = 3;
            btnReparacion.Text = "Reparacion";
            btnReparacion.TextAlign = ContentAlignment.BottomCenter;
            btnReparacion.UseVisualStyleBackColor = false;
            btnReparacion.Click += btnReparacion_Click;
            // 
            // buttonToggle
            // 
            buttonToggle.BackColor = Color.FromArgb(242, 39, 56);
            buttonToggle.FlatStyle = FlatStyle.Flat;
            buttonToggle.Font = new Font("Consolas", 12F, FontStyle.Bold);
            buttonToggle.ForeColor = Color.White;
            buttonToggle.Location = new Point(150, 3);
            buttonToggle.Name = "buttonToggle";
            buttonToggle.Size = new Size(33, 31);
            buttonToggle.TabIndex = 1;
            buttonToggle.Text = "☰";
            buttonToggle.UseVisualStyleBackColor = false;
            buttonToggle.Click += buttonToggle_Click;
            // 
            // PanelBase
            // 
            PanelBase.BackColor = Color.FromArgb(26, 26, 26);
            PanelBase.Controls.Add(buttonToggle);
            PanelBase.Controls.Add(PanelVistas);
            PanelBase.Dock = DockStyle.Fill;
            PanelBase.Location = new Point(0, 0);
            PanelBase.Name = "PanelBase";
            PanelBase.Size = new Size(1102, 667);
            PanelBase.TabIndex = 2;
            // 
            // PanelVistas
            // 
            PanelVistas.BackColor = Color.FromArgb(64, 64, 64);
            PanelVistas.Location = new Point(3, 3);
            PanelVistas.Name = "PanelVistas";
            PanelVistas.Size = new Size(1095, 660);
            PanelVistas.TabIndex = 2;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1102, 667);
            Controls.Add(panelSidebar);
            Controls.Add(PanelBase);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reparación de Móviles";
            panelSidebar.ResumeLayout(false);
            PanelBase.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelSidebar;
        private Button buttonToggle;
        private Button buttonClientes;
        private Button buttonEquipo;
        private Button buttonRepuestos;
        private Button btnReparacion;
        private Panel PanelBase;
        private Panel PanelVistas;
        private Button buttonTecnico;
        private Button btnSeguimiento;
    }
}
