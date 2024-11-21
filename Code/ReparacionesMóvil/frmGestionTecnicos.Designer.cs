namespace CapaPresentacion
{
    partial class frmGestionTecnicos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnNuevo = new Button();
            btnGuardar = new Button();
            buttonEditar = new Button();
            btnEliminar = new Button();
            dgvTecnicos = new DataGridView();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            lbTitulo = new Label();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtEspecialidad = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(115, 14, 32);
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(12, 341);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(106, 30);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(242, 39, 56);
            btnGuardar.Enabled = false;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(128, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DarkGray;
            buttonEditar.Enabled = false;
            buttonEditar.FlatStyle = FlatStyle.Popup;
            buttonEditar.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(74, 378);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(106, 30);
            buttonEditar.TabIndex = 13;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.Enabled = false;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(189, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 30);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTecnicos
            // 
            dgvTecnicos.BackgroundColor = Color.FromArgb(13, 13, 13);
            dgvTecnicos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 14, 32);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTecnicos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTecnicos.EnableHeadersVisualStyles = false;
            dgvTecnicos.GridColor = SystemColors.ButtonShadow;
            dgvTecnicos.Location = new Point(379, 12);
            dgvTecnicos.Name = "dgvTecnicos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTecnicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTecnicos.RowHeadersWidth = 51;
            dgvTecnicos.Size = new Size(557, 434);
            dgvTecnicos.TabIndex = 15;
            dgvTecnicos.CellClick += dgvTecnicos_CellClick;
            dgvTecnicos.CellContentClick += dgvTecnicos_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 39, 56);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(244, 341);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 30);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTitulo);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(115, 14, 32);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(339, 306);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro Tecnico";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.FromArgb(242, 39, 56);
            lbTitulo.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.AntiqueWhite;
            lbTitulo.Location = new Point(6, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(259, 28);
            lbTitulo.TabIndex = 10;
            lbTitulo.Text = "Registro de Tecnico";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(18, 18, 18);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.ForeColor = Color.FromArgb(242, 39, 56);
            txtCorreo.Location = new Point(13, 233);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(319, 31);
            txtCorreo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(18, 18, 18);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.FromArgb(242, 39, 56);
            txtNombre.Location = new Point(14, 56);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 31);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 211);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = Color.FromArgb(18, 18, 18);
            txtEspecialidad.BorderStyle = BorderStyle.None;
            txtEspecialidad.ForeColor = Color.FromArgb(242, 39, 56);
            txtEspecialidad.Location = new Point(14, 170);
            txtEspecialidad.Margin = new Padding(4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(319, 31);
            txtEspecialidad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 1;
            label2.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(18, 18, 18);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.FromArgb(242, 39, 56);
            txtTelefono.Location = new Point(14, 115);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(319, 31);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 151);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 2;
            label3.Text = "Especialidad";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 13, 13);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(buttonEditar);
            panel1.Location = new Point(9, 12);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 434);
            panel1.TabIndex = 18;
            // 
            // frmGestionTecnicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(958, 495);
            Controls.Add(dgvTecnicos);
            Controls.Add(panel1);
            ForeColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestionTecnicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionTecnicos";
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnNuevo;
        private Button btnGuardar;
        private Button buttonEditar;
        private Button btnEliminar;
        private DataGridView dgvTecnicos;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private TextBox txtEspecialidad;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private Panel panel1;
        private Label lbTitulo;
    }
}