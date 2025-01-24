using System.Drawing;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    partial class frmGestionCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PanelFormularioCliente = new Panel();
            buttonEditar = new Button();
            gbRegistroCliente = new GroupBox();
            lbTitulo = new Label();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lbNombre = new Label();
            lbCorreo = new Label();
            txtDireccion = new TextBox();
            lbTelefono = new Label();
            txtTelefono = new TextBox();
            lbDireccion = new Label();
            btnEliminar = new Button();
            btnGuardarResgistroCliente = new Button();
            btnNuevoRegistroCliente = new Button();
            btnCancelarRegistroCliente = new Button();
            dgvClientes = new DataGridView();
            PanelFormularioCliente.SuspendLayout();
            gbRegistroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // PanelFormularioCliente
            // 
            PanelFormularioCliente.BackColor = Color.FromArgb(13, 13, 13);
            PanelFormularioCliente.Controls.Add(buttonEditar);
            PanelFormularioCliente.Controls.Add(gbRegistroCliente);
            PanelFormularioCliente.Controls.Add(btnEliminar);
            PanelFormularioCliente.Controls.Add(btnGuardarResgistroCliente);
            PanelFormularioCliente.Controls.Add(btnNuevoRegistroCliente);
            PanelFormularioCliente.Controls.Add(btnCancelarRegistroCliente);
            PanelFormularioCliente.Location = new Point(9, 54);
            PanelFormularioCliente.Name = "PanelFormularioCliente";
            PanelFormularioCliente.Size = new Size(333, 463);
            PanelFormularioCliente.TabIndex = 0;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DarkGray;
            buttonEditar.Enabled = false;
            buttonEditar.FlatStyle = FlatStyle.Popup;
            buttonEditar.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            buttonEditar.ForeColor = Color.AntiqueWhite;
            buttonEditar.Location = new Point(14, 383);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(97, 32);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Visible = false;
            // 
            // gbRegistroCliente
            // 
            gbRegistroCliente.Controls.Add(lbTitulo);
            gbRegistroCliente.Controls.Add(txtCorreo);
            gbRegistroCliente.Controls.Add(txtNombre);
            gbRegistroCliente.Controls.Add(lbNombre);
            gbRegistroCliente.Controls.Add(lbCorreo);
            gbRegistroCliente.Controls.Add(txtDireccion);
            gbRegistroCliente.Controls.Add(lbTelefono);
            gbRegistroCliente.Controls.Add(txtTelefono);
            gbRegistroCliente.Controls.Add(lbDireccion);
            gbRegistroCliente.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRegistroCliente.ForeColor = Color.FromArgb(115, 14, 32);
            gbRegistroCliente.Location = new Point(14, 61);
            gbRegistroCliente.Margin = new Padding(3, 2, 3, 2);
            gbRegistroCliente.Name = "gbRegistroCliente";
            gbRegistroCliente.Padding = new Padding(3, 2, 3, 2);
            gbRegistroCliente.Size = new Size(309, 300);
            gbRegistroCliente.TabIndex = 8;
            gbRegistroCliente.TabStop = false;
            gbRegistroCliente.Text = "Registro Cliente";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.FromArgb(128, 255, 255);
            lbTitulo.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.Black;
            lbTitulo.Location = new Point(6, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(259, 28);
            lbTitulo.TabIndex = 3;
            lbTitulo.Text = "Registro de Cliente";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(18, 18, 18);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.ForeColor = Color.FromArgb(242, 39, 56);
            txtCorreo.Location = new Point(26, 248);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(255, 31);
            txtCorreo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(18, 18, 18);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.FromArgb(242, 39, 56);
            txtNombre.Location = new Point(26, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 31);
            txtNombre.TabIndex = 3;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbNombre.ForeColor = Color.AntiqueWhite;
            lbNombre.Location = new Point(26, 52);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 18);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbCorreo.ForeColor = Color.AntiqueWhite;
            lbCorreo.Location = new Point(26, 227);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(64, 18);
            lbCorreo.TabIndex = 6;
            lbCorreo.Text = "Correo:";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(18, 18, 18);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.ForeColor = Color.FromArgb(242, 39, 56);
            txtDireccion.Location = new Point(26, 186);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(255, 31);
            txtDireccion.TabIndex = 4;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbTelefono.ForeColor = Color.AntiqueWhite;
            lbTelefono.Location = new Point(26, 110);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(80, 18);
            lbTelefono.TabIndex = 1;
            lbTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(18, 18, 18);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.FromArgb(242, 39, 56);
            txtTelefono.Location = new Point(26, 130);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(255, 31);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbDireccion.ForeColor = Color.AntiqueWhite;
            lbDireccion.Location = new Point(26, 167);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(88, 18);
            lbDireccion.TabIndex = 2;
            lbDireccion.Text = "Dirección:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.Enabled = false;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.AntiqueWhite;
            btnEliminar.Location = new Point(14, 422);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 32);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardarResgistroCliente
            // 
            btnGuardarResgistroCliente.Enabled = false;
            btnGuardarResgistroCliente.FlatStyle = FlatStyle.Flat;
            btnGuardarResgistroCliente.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnGuardarResgistroCliente.ForeColor = Color.AntiqueWhite;
            btnGuardarResgistroCliente.Location = new Point(226, 383);
            btnGuardarResgistroCliente.Name = "btnGuardarResgistroCliente";
            btnGuardarResgistroCliente.Size = new Size(97, 32);
            btnGuardarResgistroCliente.TabIndex = 3;
            btnGuardarResgistroCliente.Text = "Guardar";
            btnGuardarResgistroCliente.UseVisualStyleBackColor = false;
            btnGuardarResgistroCliente.Click += btnGuardar_Click;
            // 
            // btnNuevoRegistroCliente
            // 
            btnNuevoRegistroCliente.BackColor = Color.FromArgb(192, 255, 255);
            btnNuevoRegistroCliente.FlatStyle = FlatStyle.Popup;
            btnNuevoRegistroCliente.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnNuevoRegistroCliente.ForeColor = Color.Black;
            btnNuevoRegistroCliente.Location = new Point(14, 10);
            btnNuevoRegistroCliente.Name = "btnNuevoRegistroCliente";
            btnNuevoRegistroCliente.Size = new Size(97, 32);
            btnNuevoRegistroCliente.TabIndex = 0;
            btnNuevoRegistroCliente.Text = "Nuevo";
            btnNuevoRegistroCliente.UseVisualStyleBackColor = false;
            btnNuevoRegistroCliente.Click += btnNuevo_Click;
            // 
            // btnCancelarRegistroCliente
            // 
            btnCancelarRegistroCliente.BackColor = Color.FromArgb(128, 255, 255);
            btnCancelarRegistroCliente.FlatStyle = FlatStyle.Popup;
            btnCancelarRegistroCliente.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnCancelarRegistroCliente.ForeColor = Color.Black;
            btnCancelarRegistroCliente.Location = new Point(226, 422);
            btnCancelarRegistroCliente.Name = "btnCancelarRegistroCliente";
            btnCancelarRegistroCliente.Size = new Size(97, 32);
            btnCancelarRegistroCliente.TabIndex = 1;
            btnCancelarRegistroCliente.Text = "Cancelar";
            btnCancelarRegistroCliente.UseVisualStyleBackColor = false;
            btnCancelarRegistroCliente.Visible = false;
            btnCancelarRegistroCliente.Click += btnCancelar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.FromArgb(17, 17, 17);
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle1.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 14, 32);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = SystemColors.ButtonShadow;
            dgvClientes.Location = new Point(349, 54);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.ScrollBars = ScrollBars.Horizontal;
            dgvClientes.Size = new Size(517, 463);
            dgvClientes.TabIndex = 2;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // frmGestionCliente
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(876, 528);
            Controls.Add(dgvClientes);
            Controls.Add(PanelFormularioCliente);
            ForeColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestionCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            Load += frmGestionCliente_Load;
            PanelFormularioCliente.ResumeLayout(false);
            gbRegistroCliente.ResumeLayout(false);
            gbRegistroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        private Panel PanelFormularioCliente;
        private TextBox txtCorreo;
        private Label lbCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lbDireccion;
        private Label lbTelefono;
        private Label lbNombre;
        private Button btnGuardarResgistroCliente;
        private Button btnNuevoRegistroCliente;
        private Button btnEliminar;
        private Button btnCancelarRegistroCliente;
        private DataGridView dgvClientes;
        private Label lbTitulo;
        private Button buttonEditar;
        private GroupBox gbRegistroCliente;
    }
}
