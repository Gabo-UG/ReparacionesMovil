using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    partial class frmRegistroRepuesto : Form
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lbTitulo = new Label();
            txtRepuestoCodigo = new TextBox();
            label10 = new Label();
            txtRepuestoPrecio = new TextBox();
            txtRepuestoNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEliminarRepuesto = new Button();
            btnGuardarRepuesto = new Button();
            btnNuevoRepuesto = new Button();
            btnCancelarRepuesto = new Button();
            dgvRepuesto = new DataGridView();
            label3 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            label11 = new Label();
            cmbCategoria = new ComboBox();
            txtServicioNombre = new TextBox();
            txtServicioCodigo = new TextBox();
            txtServicioPrecio = new TextBox();
            txtServicioIva = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnEliminarServicio = new Button();
            btnGuardarServicio = new Button();
            btnNuevoServicio = new Button();
            btnCancelarServicio = new Button();
            dgvServicio = new DataGridView();
            usuarioBindingSource = new BindingSource(components);
            usuarioBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepuesto).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 13, 13);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEliminarRepuesto);
            panel1.Controls.Add(btnGuardarRepuesto);
            panel1.Controls.Add(btnNuevoRepuesto);
            panel1.Controls.Add(btnCancelarRepuesto);
            panel1.Location = new Point(24, 10);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 274);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTitulo);
            groupBox1.Controls.Add(txtRepuestoCodigo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtRepuestoPrecio);
            groupBox1.Controls.Add(txtRepuestoNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(115, 14, 32);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 251);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro Producto";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.FromArgb(242, 39, 56);
            lbTitulo.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.AntiqueWhite;
            lbTitulo.Location = new Point(10, 5);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(272, 28);
            lbTitulo.TabIndex = 9;
            lbTitulo.Text = "Registro de Producto";
            // 
            // txtRepuestoCodigo
            // 
            txtRepuestoCodigo.BackColor = Color.FromArgb(18, 18, 18);
            txtRepuestoCodigo.BorderStyle = BorderStyle.None;
            txtRepuestoCodigo.ForeColor = Color.FromArgb(242, 39, 56);
            txtRepuestoCodigo.Location = new Point(14, 64);
            txtRepuestoCodigo.Margin = new Padding(4, 4, 4, 4);
            txtRepuestoCodigo.Name = "txtRepuestoCodigo";
            txtRepuestoCodigo.Size = new Size(302, 31);
            txtRepuestoCodigo.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label10.ForeColor = Color.AntiqueWhite;
            label10.Location = new Point(14, 37);
            label10.Name = "label10";
            label10.Size = new Size(64, 18);
            label10.TabIndex = 7;
            label10.Text = "Codigo:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRepuestoPrecio
            // 
            txtRepuestoPrecio.BackColor = Color.FromArgb(18, 18, 18);
            txtRepuestoPrecio.BorderStyle = BorderStyle.None;
            txtRepuestoPrecio.ForeColor = Color.FromArgb(242, 39, 56);
            txtRepuestoPrecio.Location = new Point(215, 193);
            txtRepuestoPrecio.Margin = new Padding(4, 4, 4, 4);
            txtRepuestoPrecio.Name = "txtRepuestoPrecio";
            txtRepuestoPrecio.Size = new Size(88, 31);
            txtRepuestoPrecio.TabIndex = 4;
            // 
            // txtRepuestoNombre
            // 
            txtRepuestoNombre.BackColor = Color.FromArgb(18, 18, 18);
            txtRepuestoNombre.BorderStyle = BorderStyle.None;
            txtRepuestoNombre.ForeColor = Color.FromArgb(242, 39, 56);
            txtRepuestoNombre.Location = new Point(14, 128);
            txtRepuestoNombre.Margin = new Padding(4, 4, 4, 4);
            txtRepuestoNombre.Name = "txtRepuestoNombre";
            txtRepuestoNombre.Size = new Size(302, 31);
            txtRepuestoNombre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(14, 106);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "Repuesto:";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(215, 170);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // btnEliminarRepuesto
            // 
            btnEliminarRepuesto.BackColor = Color.DarkGray;
            btnEliminarRepuesto.Enabled = false;
            btnEliminarRepuesto.FlatStyle = FlatStyle.Popup;
            btnEliminarRepuesto.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnEliminarRepuesto.ForeColor = Color.White;
            btnEliminarRepuesto.Location = new Point(346, 120);
            btnEliminarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarRepuesto.Name = "btnEliminarRepuesto";
            btnEliminarRepuesto.Size = new Size(97, 24);
            btnEliminarRepuesto.TabIndex = 2;
            btnEliminarRepuesto.Text = "Eliminar";
            btnEliminarRepuesto.UseVisualStyleBackColor = false;
            btnEliminarRepuesto.Click += btnEliminarRepuesto_Click;
            // 
            // btnGuardarRepuesto
            // 
            btnGuardarRepuesto.BackColor = Color.FromArgb(242, 39, 56);
            btnGuardarRepuesto.Enabled = false;
            btnGuardarRepuesto.FlatStyle = FlatStyle.Popup;
            btnGuardarRepuesto.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnGuardarRepuesto.ForeColor = Color.White;
            btnGuardarRepuesto.Location = new Point(346, 85);
            btnGuardarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnGuardarRepuesto.Name = "btnGuardarRepuesto";
            btnGuardarRepuesto.Size = new Size(97, 27);
            btnGuardarRepuesto.TabIndex = 3;
            btnGuardarRepuesto.Text = "Guardar";
            btnGuardarRepuesto.UseVisualStyleBackColor = false;
            btnGuardarRepuesto.Click += btnGuardarRepuesto_Click;
            // 
            // btnNuevoRepuesto
            // 
            btnNuevoRepuesto.BackColor = Color.FromArgb(115, 14, 32);
            btnNuevoRepuesto.FlatStyle = FlatStyle.Popup;
            btnNuevoRepuesto.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnNuevoRepuesto.ForeColor = Color.White;
            btnNuevoRepuesto.Location = new Point(346, 48);
            btnNuevoRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnNuevoRepuesto.Name = "btnNuevoRepuesto";
            btnNuevoRepuesto.Size = new Size(97, 29);
            btnNuevoRepuesto.TabIndex = 0;
            btnNuevoRepuesto.Text = "Nuevo";
            btnNuevoRepuesto.UseVisualStyleBackColor = false;
            btnNuevoRepuesto.Click += btnNuevoRepuesto_Click;
            // 
            // btnCancelarRepuesto
            // 
            btnCancelarRepuesto.BackColor = Color.FromArgb(242, 39, 56);
            btnCancelarRepuesto.FlatStyle = FlatStyle.Popup;
            btnCancelarRepuesto.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnCancelarRepuesto.ForeColor = Color.White;
            btnCancelarRepuesto.Location = new Point(346, 152);
            btnCancelarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnCancelarRepuesto.Name = "btnCancelarRepuesto";
            btnCancelarRepuesto.Size = new Size(97, 27);
            btnCancelarRepuesto.TabIndex = 1;
            btnCancelarRepuesto.Text = "Cancelar";
            btnCancelarRepuesto.UseVisualStyleBackColor = false;
            btnCancelarRepuesto.Visible = false;
            btnCancelarRepuesto.Click += btnCancelarRepuesto_Click;
            // 
            // dgvRepuesto
            // 
            dgvRepuesto.BackgroundColor = Color.FromArgb(13, 13, 13);
            dgvRepuesto.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 14, 32);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRepuesto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRepuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRepuesto.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRepuesto.EnableHeadersVisualStyles = false;
            dgvRepuesto.GridColor = SystemColors.ButtonShadow;
            dgvRepuesto.Location = new Point(24, 292);
            dgvRepuesto.Margin = new Padding(3, 4, 3, 4);
            dgvRepuesto.Name = "dgvRepuesto";
            dgvRepuesto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRepuesto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRepuesto.RowHeadersWidth = 51;
            dgvRepuesto.Size = new Size(452, 192);
            dgvRepuesto.TabIndex = 4;
            dgvRepuesto.CellClick += dgvRepuesto_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(115, 14, 32);
            label3.Location = new Point(39, 20);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 13, 13);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(btnEliminarServicio);
            panel2.Controls.Add(btnGuardarServicio);
            panel2.Controls.Add(btnNuevoServicio);
            panel2.Controls.Add(btnCancelarServicio);
            panel2.Location = new Point(481, 10);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 274);
            panel2.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmbCategoria);
            groupBox2.Controls.Add(txtServicioNombre);
            groupBox2.Controls.Add(txtServicioCodigo);
            groupBox2.Controls.Add(txtServicioPrecio);
            groupBox2.Controls.Add(txtServicioIva);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(115, 14, 32);
            groupBox2.Location = new Point(11, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 251);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro Servicios";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(242, 39, 56);
            label11.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.AntiqueWhite;
            label11.Location = new Point(6, 5);
            label11.Name = "label11";
            label11.Size = new Size(285, 28);
            label11.TabIndex = 10;
            label11.Text = "Registro de Servicios";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(18, 18, 18);
            cmbCategoria.Enabled = false;
            cmbCategoria.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.ForeColor = Color.FromArgb(242, 39, 56);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Seleccione", "Reparacion", "Mantenimiento" });
            cmbCategoria.Location = new Point(14, 193);
            cmbCategoria.Margin = new Padding(4, 4, 4, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(225, 30);
            cmbCategoria.TabIndex = 11;
            // 
            // txtServicioNombre
            // 
            txtServicioNombre.BackColor = Color.FromArgb(18, 18, 18);
            txtServicioNombre.BorderStyle = BorderStyle.None;
            txtServicioNombre.ForeColor = Color.FromArgb(242, 39, 56);
            txtServicioNombre.Location = new Point(14, 126);
            txtServicioNombre.Margin = new Padding(4, 4, 4, 4);
            txtServicioNombre.Name = "txtServicioNombre";
            txtServicioNombre.Size = new Size(302, 31);
            txtServicioNombre.TabIndex = 4;
            // 
            // txtServicioCodigo
            // 
            txtServicioCodigo.BackColor = Color.FromArgb(18, 18, 18);
            txtServicioCodigo.BorderStyle = BorderStyle.None;
            txtServicioCodigo.ForeColor = Color.FromArgb(242, 39, 56);
            txtServicioCodigo.Location = new Point(14, 56);
            txtServicioCodigo.Margin = new Padding(4, 4, 4, 4);
            txtServicioCodigo.Name = "txtServicioCodigo";
            txtServicioCodigo.Size = new Size(302, 31);
            txtServicioCodigo.TabIndex = 4;
            // 
            // txtServicioPrecio
            // 
            txtServicioPrecio.BackColor = Color.FromArgb(18, 18, 18);
            txtServicioPrecio.BorderStyle = BorderStyle.None;
            txtServicioPrecio.ForeColor = Color.FromArgb(242, 39, 56);
            txtServicioPrecio.Location = new Point(246, 193);
            txtServicioPrecio.Margin = new Padding(4, 4, 4, 4);
            txtServicioPrecio.Name = "txtServicioPrecio";
            txtServicioPrecio.Size = new Size(84, 31);
            txtServicioPrecio.TabIndex = 4;
            // 
            // txtServicioIva
            // 
            txtServicioIva.BackColor = Color.FromArgb(13, 13, 13);
            txtServicioIva.BorderStyle = BorderStyle.FixedSingle;
            txtServicioIva.ForeColor = Color.FromArgb(242, 39, 56);
            txtServicioIva.Location = new Point(14, 320);
            txtServicioIva.Margin = new Padding(3, 4, 3, 4);
            txtServicioIva.Name = "txtServicioIva";
            txtServicioIva.Size = new Size(117, 38);
            txtServicioIva.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.AntiqueWhite;
            label5.Location = new Point(14, 104);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 0;
            label5.Text = "Servicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.AntiqueWhite;
            label6.Location = new Point(14, 170);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 1;
            label6.Text = "Categoria:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.AntiqueWhite;
            label7.Location = new Point(14, 34);
            label7.Name = "label7";
            label7.Size = new Size(64, 18);
            label7.TabIndex = 2;
            label7.Text = "Codigo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.AntiqueWhite;
            label8.Location = new Point(246, 171);
            label8.Name = "label8";
            label8.Size = new Size(64, 18);
            label8.TabIndex = 3;
            label8.Text = "Precio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(242, 39, 56);
            label9.Location = new Point(14, 300);
            label9.Name = "label9";
            label9.Size = new Size(40, 18);
            label9.TabIndex = 4;
            label9.Text = "Iva:";
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.BackColor = Color.DarkGray;
            btnEliminarServicio.Enabled = false;
            btnEliminarServicio.FlatStyle = FlatStyle.Popup;
            btnEliminarServicio.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnEliminarServicio.ForeColor = Color.White;
            btnEliminarServicio.Location = new Point(359, 120);
            btnEliminarServicio.Margin = new Padding(3, 4, 3, 4);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(97, 24);
            btnEliminarServicio.TabIndex = 2;
            btnEliminarServicio.Text = "Eliminar";
            btnEliminarServicio.UseVisualStyleBackColor = false;
            btnEliminarServicio.Click += btnEliminarServicio_Click;
            // 
            // btnGuardarServicio
            // 
            btnGuardarServicio.BackColor = Color.FromArgb(242, 39, 56);
            btnGuardarServicio.Enabled = false;
            btnGuardarServicio.FlatStyle = FlatStyle.Popup;
            btnGuardarServicio.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnGuardarServicio.ForeColor = Color.White;
            btnGuardarServicio.Location = new Point(359, 82);
            btnGuardarServicio.Margin = new Padding(3, 4, 3, 4);
            btnGuardarServicio.Name = "btnGuardarServicio";
            btnGuardarServicio.Size = new Size(97, 29);
            btnGuardarServicio.TabIndex = 9;
            btnGuardarServicio.Text = "Guardar";
            btnGuardarServicio.UseVisualStyleBackColor = false;
            btnGuardarServicio.Click += btnGuardarServicio_Click;
            // 
            // btnNuevoServicio
            // 
            btnNuevoServicio.BackColor = Color.FromArgb(115, 14, 32);
            btnNuevoServicio.FlatStyle = FlatStyle.Popup;
            btnNuevoServicio.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnNuevoServicio.ForeColor = Color.White;
            btnNuevoServicio.Location = new Point(359, 51);
            btnNuevoServicio.Margin = new Padding(3, 4, 3, 4);
            btnNuevoServicio.Name = "btnNuevoServicio";
            btnNuevoServicio.Size = new Size(97, 23);
            btnNuevoServicio.TabIndex = 0;
            btnNuevoServicio.Text = "Nuevo";
            btnNuevoServicio.UseVisualStyleBackColor = false;
            btnNuevoServicio.Click += btnNuevoServicio_Click;
            // 
            // btnCancelarServicio
            // 
            btnCancelarServicio.BackColor = Color.FromArgb(242, 39, 56);
            btnCancelarServicio.FlatStyle = FlatStyle.Popup;
            btnCancelarServicio.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnCancelarServicio.ForeColor = Color.White;
            btnCancelarServicio.Location = new Point(359, 152);
            btnCancelarServicio.Margin = new Padding(3, 4, 3, 4);
            btnCancelarServicio.Name = "btnCancelarServicio";
            btnCancelarServicio.Size = new Size(97, 28);
            btnCancelarServicio.TabIndex = 1;
            btnCancelarServicio.Text = "Cancelar";
            btnCancelarServicio.UseVisualStyleBackColor = false;
            btnCancelarServicio.Visible = false;
            btnCancelarServicio.Click += btnCancelarServicio_Click;
            // 
            // dgvServicio
            // 
            dgvServicio.BackgroundColor = Color.FromArgb(13, 13, 13);
            dgvServicio.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(115, 14, 32);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvServicio.DefaultCellStyle = dataGridViewCellStyle5;
            dgvServicio.EnableHeadersVisualStyles = false;
            dgvServicio.GridColor = SystemColors.ButtonShadow;
            dgvServicio.Location = new Point(481, 292);
            dgvServicio.Margin = new Padding(3, 4, 3, 4);
            dgvServicio.Name = "dgvServicio";
            dgvServicio.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvServicio.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvServicio.RowHeadersWidth = 51;
            dgvServicio.Size = new Size(466, 193);
            dgvServicio.TabIndex = 10;
            dgvServicio.CellClick += dgvServicio_CellClick;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Negocio.Entidades.Usuario);
            // 
            // usuarioBindingSource1
            // 
            usuarioBindingSource1.DataSource = typeof(Negocio.Entidades.Usuario);
            // 
            // frmRegistroRepuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(958, 495);
            Controls.Add(dgvServicio);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(dgvRepuesto);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistroRepuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Repuesto";
            Load += frmRegistroRepuesto_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepuesto).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtRepuestoPrecio;
        private TextBox txtRepuestoNombre;
        private Label label1;
        private Label label2;
        private Button btnEliminarRepuesto;
        private Button btnGuardarRepuesto;
        private Button btnNuevoRepuesto;
        private Button btnCancelarRepuesto;
        private DataGridView dgvRepuesto;
        private Label label3;
        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox txtServicioNombre;
        private TextBox txtServicioCodigo;
        private TextBox txtServicioPrecio;
        private TextBox txtServicioIva;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnEliminarServicio;
        private Button btnNuevoServicio;
        private Button btnCancelarServicio;
        private Button btnGuardarServicio;
        private DataGridView dgvServicio;
        private Label label10;
        private TextBox txtRepuestoCodigo;
        private ComboBox cmbCategoria;
        private BindingSource usuarioBindingSource;
        private BindingSource usuarioBindingSource1;
        private Label lbTitulo;
        private Label label11;
    }
}
