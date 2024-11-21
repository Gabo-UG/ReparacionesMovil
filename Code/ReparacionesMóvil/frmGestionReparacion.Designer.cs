namespace CapaPresentacion
{
    partial class frmGestionReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            checkedListBoxRepuesto = new CheckedListBox();
            checkedListBoxServicio = new CheckedListBox();
            lbRepuestos = new Label();
            richTextBoxDiagnosticos = new RichTextBox();
            lbDiagnosticos = new Label();
            cbTecnico = new ComboBox();
            cbCliente = new ComboBox();
            cbEquipo = new ComboBox();
            btnGuardarReparacion = new Button();
            label1 = new Label();
            lbServicios = new Label();
            lbCTecnico = new Label();
            lbCCliente = new Label();
            lbCEquipo = new Label();
            btnAddClientelpanel = new Button();
            AddEquipopanel = new Button();
            AddTecnicopanel = new Button();
            btnNuevaReparacion = new Button();
            btnCancelarReparacion = new Button();
            dgvReparacion = new DataGridView();
            lbTotalServicios = new Label();
            lbTotalReparacion = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lbIngreso = new Label();
            lbEntrega = new Label();
            lbTotalRepuestos = new Label();
            lbTotalIVA = new Label();
            labelIVA = new Label();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReparacion).BeginInit();
            SuspendLayout();
            // 
            // checkedListBoxRepuesto
            // 
            checkedListBoxRepuesto.BackColor = Color.FromArgb(18, 18, 18);
            checkedListBoxRepuesto.ForeColor = Color.AntiqueWhite;
            checkedListBoxRepuesto.FormattingEnabled = true;
            checkedListBoxRepuesto.Location = new Point(21, 335);
            checkedListBoxRepuesto.Name = "checkedListBoxRepuesto";
            checkedListBoxRepuesto.Size = new Size(309, 246);
            checkedListBoxRepuesto.TabIndex = 0;
            // 
            // checkedListBoxServicio
            // 
            checkedListBoxServicio.BackColor = Color.FromArgb(18, 18, 18);
            checkedListBoxServicio.ForeColor = Color.AntiqueWhite;
            checkedListBoxServicio.FormattingEnabled = true;
            checkedListBoxServicio.Location = new Point(340, 335);
            checkedListBoxServicio.Name = "checkedListBoxServicio";
            checkedListBoxServicio.Size = new Size(309, 246);
            checkedListBoxServicio.TabIndex = 1;
            // 
            // lbRepuestos
            // 
            lbRepuestos.AutoSize = true;
            lbRepuestos.BackColor = Color.FromArgb(18, 18, 18);
            lbRepuestos.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbRepuestos.ForeColor = Color.AntiqueWhite;
            lbRepuestos.Location = new Point(21, 312);
            lbRepuestos.Name = "lbRepuestos";
            lbRepuestos.Size = new Size(100, 22);
            lbRepuestos.TabIndex = 2;
            lbRepuestos.Text = "Repuestos";
            // 
            // richTextBoxDiagnosticos
            // 
            richTextBoxDiagnosticos.BackColor = Color.FromArgb(18, 18, 18);
            richTextBoxDiagnosticos.ForeColor = Color.AntiqueWhite;
            richTextBoxDiagnosticos.Location = new Point(21, 189);
            richTextBoxDiagnosticos.Name = "richTextBoxDiagnosticos";
            richTextBoxDiagnosticos.Size = new Size(418, 120);
            richTextBoxDiagnosticos.TabIndex = 3;
            richTextBoxDiagnosticos.Text = "";
            // 
            // lbDiagnosticos
            // 
            lbDiagnosticos.AutoSize = true;
            lbDiagnosticos.BackColor = Color.FromArgb(18, 18, 18);
            lbDiagnosticos.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbDiagnosticos.ForeColor = Color.AntiqueWhite;
            lbDiagnosticos.Location = new Point(21, 166);
            lbDiagnosticos.Name = "lbDiagnosticos";
            lbDiagnosticos.Size = new Size(120, 22);
            lbDiagnosticos.TabIndex = 4;
            lbDiagnosticos.Text = "Diagnostico";
            // 
            // cbTecnico
            // 
            cbTecnico.BackColor = Color.FromArgb(18, 18, 18);
            cbTecnico.Font = new Font("Consolas", 12F, FontStyle.Bold);
            cbTecnico.ForeColor = Color.FromArgb(242, 39, 56);
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(125, 127);
            cbTecnico.Name = "cbTecnico";
            cbTecnico.Size = new Size(230, 31);
            cbTecnico.TabIndex = 5;
            // 
            // cbCliente
            // 
            cbCliente.BackColor = Color.FromArgb(18, 18, 18);
            cbCliente.Font = new Font("Consolas", 12F, FontStyle.Bold);
            cbCliente.ForeColor = Color.FromArgb(242, 39, 56);
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(127, 42);
            cbCliente.Margin = new Padding(5);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(230, 31);
            cbCliente.TabIndex = 6;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // cbEquipo
            // 
            cbEquipo.BackColor = Color.FromArgb(18, 18, 18);
            cbEquipo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            cbEquipo.ForeColor = Color.FromArgb(242, 39, 56);
            cbEquipo.FormattingEnabled = true;
            cbEquipo.Location = new Point(125, 85);
            cbEquipo.Name = "cbEquipo";
            cbEquipo.Size = new Size(230, 31);
            cbEquipo.TabIndex = 7;
            // 
            // btnGuardarReparacion
            // 
            btnGuardarReparacion.BackColor = Color.FromArgb(115, 14, 32);
            btnGuardarReparacion.FlatStyle = FlatStyle.Popup;
            btnGuardarReparacion.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnGuardarReparacion.ForeColor = Color.AntiqueWhite;
            btnGuardarReparacion.Location = new Point(508, 231);
            btnGuardarReparacion.Name = "btnGuardarReparacion";
            btnGuardarReparacion.Size = new Size(89, 32);
            btnGuardarReparacion.TabIndex = 9;
            btnGuardarReparacion.Text = "Guardar";
            btnGuardarReparacion.UseVisualStyleBackColor = false;
            btnGuardarReparacion.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 314);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            // 
            // lbServicios
            // 
            lbServicios.AutoSize = true;
            lbServicios.BackColor = Color.FromArgb(18, 18, 18);
            lbServicios.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbServicios.ForeColor = Color.AntiqueWhite;
            lbServicios.Location = new Point(336, 314);
            lbServicios.Name = "lbServicios";
            lbServicios.Size = new Size(100, 22);
            lbServicios.TabIndex = 11;
            lbServicios.Text = "Servicios";
            // 
            // lbCTecnico
            // 
            lbCTecnico.AutoSize = true;
            lbCTecnico.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lbCTecnico.ForeColor = Color.FromArgb(242, 39, 56);
            lbCTecnico.Location = new Point(21, 126);
            lbCTecnico.Name = "lbCTecnico";
            lbCTecnico.Size = new Size(98, 23);
            lbCTecnico.TabIndex = 12;
            lbCTecnico.Text = "Tecnico:";
            // 
            // lbCCliente
            // 
            lbCCliente.AutoSize = true;
            lbCCliente.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lbCCliente.ForeColor = Color.FromArgb(242, 39, 56);
            lbCCliente.Location = new Point(21, 51);
            lbCCliente.Name = "lbCCliente";
            lbCCliente.Size = new Size(98, 23);
            lbCCliente.TabIndex = 13;
            lbCCliente.Text = "Cliente:";
            // 
            // lbCEquipo
            // 
            lbCEquipo.AutoSize = true;
            lbCEquipo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lbCEquipo.ForeColor = Color.FromArgb(242, 39, 56);
            lbCEquipo.Location = new Point(32, 88);
            lbCEquipo.Name = "lbCEquipo";
            lbCEquipo.Size = new Size(87, 23);
            lbCEquipo.TabIndex = 14;
            lbCEquipo.Text = "Equipo:";
            // 
            // btnAddClientelpanel
            // 
            btnAddClientelpanel.FlatStyle = FlatStyle.Flat;
            btnAddClientelpanel.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnAddClientelpanel.ForeColor = Color.AntiqueWhite;
            btnAddClientelpanel.Location = new Point(366, 37);
            btnAddClientelpanel.Margin = new Padding(4);
            btnAddClientelpanel.Name = "btnAddClientelpanel";
            btnAddClientelpanel.Size = new Size(77, 32);
            btnAddClientelpanel.TabIndex = 15;
            btnAddClientelpanel.Text = "Añadir";
            btnAddClientelpanel.UseVisualStyleBackColor = false;
            btnAddClientelpanel.Click += btnAddClientelpanel_Click;
            // 
            // AddEquipopanel
            // 
            AddEquipopanel.FlatStyle = FlatStyle.Flat;
            AddEquipopanel.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            AddEquipopanel.ForeColor = Color.AntiqueWhite;
            AddEquipopanel.Location = new Point(366, 84);
            AddEquipopanel.Margin = new Padding(4);
            AddEquipopanel.Name = "AddEquipopanel";
            AddEquipopanel.Size = new Size(77, 32);
            AddEquipopanel.TabIndex = 16;
            AddEquipopanel.Text = "Añadir";
            AddEquipopanel.UseVisualStyleBackColor = false;
            AddEquipopanel.Click += AddEquipopanel_Click;
            // 
            // AddTecnicopanel
            // 
            AddTecnicopanel.FlatStyle = FlatStyle.Flat;
            AddTecnicopanel.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            AddTecnicopanel.ForeColor = Color.AntiqueWhite;
            AddTecnicopanel.Location = new Point(366, 128);
            AddTecnicopanel.Margin = new Padding(4);
            AddTecnicopanel.Name = "AddTecnicopanel";
            AddTecnicopanel.Size = new Size(77, 32);
            AddTecnicopanel.TabIndex = 17;
            AddTecnicopanel.Text = "Añadir";
            AddTecnicopanel.UseVisualStyleBackColor = false;
            AddTecnicopanel.Click += AddTecnicopanel_Click;
            // 
            // btnNuevaReparacion
            // 
            btnNuevaReparacion.BackColor = Color.FromArgb(115, 14, 32);
            btnNuevaReparacion.FlatStyle = FlatStyle.Popup;
            btnNuevaReparacion.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnNuevaReparacion.ForeColor = Color.AntiqueWhite;
            btnNuevaReparacion.Location = new Point(508, 189);
            btnNuevaReparacion.Margin = new Padding(4);
            btnNuevaReparacion.Name = "btnNuevaReparacion";
            btnNuevaReparacion.Size = new Size(89, 32);
            btnNuevaReparacion.TabIndex = 18;
            btnNuevaReparacion.Text = "Nuevo";
            btnNuevaReparacion.UseVisualStyleBackColor = false;
            btnNuevaReparacion.Click += btnNuevaReparacion_Click;
            // 
            // btnCancelarReparacion
            // 
            btnCancelarReparacion.BackColor = Color.FromArgb(242, 39, 56);
            btnCancelarReparacion.FlatStyle = FlatStyle.Popup;
            btnCancelarReparacion.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnCancelarReparacion.ForeColor = Color.AntiqueWhite;
            btnCancelarReparacion.Location = new Point(508, 274);
            btnCancelarReparacion.Margin = new Padding(4);
            btnCancelarReparacion.Name = "btnCancelarReparacion";
            btnCancelarReparacion.Size = new Size(89, 32);
            btnCancelarReparacion.TabIndex = 19;
            btnCancelarReparacion.Text = "Cancelar";
            btnCancelarReparacion.UseVisualStyleBackColor = false;
            btnCancelarReparacion.Visible = false;
            // 
            // dgvReparacion
            // 
            dgvReparacion.BackgroundColor = Color.FromArgb(17, 17, 17);
            dgvReparacion.BorderStyle = BorderStyle.Fixed3D;
            dgvReparacion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle4.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(115, 14, 32);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReparacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReparacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvReparacion.DefaultCellStyle = dataGridViewCellStyle5;
            dgvReparacion.Location = new Point(663, 110);
            dgvReparacion.Name = "dgvReparacion";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvReparacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvReparacion.RowHeadersWidth = 51;
            dgvReparacion.Size = new Size(420, 528);
            dgvReparacion.TabIndex = 20;
            // 
            // lbTotalServicios
            // 
            lbTotalServicios.AutoSize = true;
            lbTotalServicios.Location = new Point(599, 584);
            lbTotalServicios.Name = "lbTotalServicios";
            lbTotalServicios.Size = new Size(44, 20);
            lbTotalServicios.TabIndex = 22;
            lbTotalServicios.Text = "00.00";
            // 
            // lbTotalReparacion
            // 
            lbTotalReparacion.AutoSize = true;
            lbTotalReparacion.Location = new Point(103, 627);
            lbTotalReparacion.Name = "lbTotalReparacion";
            lbTotalReparacion.Size = new Size(44, 20);
            lbTotalReparacion.TabIndex = 23;
            lbTotalReparacion.Text = "00.00";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(767, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(767, 70);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(316, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // lbIngreso
            // 
            lbIngreso.AutoSize = true;
            lbIngreso.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lbIngreso.ForeColor = Color.FromArgb(242, 39, 56);
            lbIngreso.Location = new Point(663, 33);
            lbIngreso.Name = "lbIngreso";
            lbIngreso.Size = new Size(98, 23);
            lbIngreso.TabIndex = 26;
            lbIngreso.Text = "Ingreso:";
            // 
            // lbEntrega
            // 
            lbEntrega.AutoSize = true;
            lbEntrega.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lbEntrega.ForeColor = Color.FromArgb(242, 39, 56);
            lbEntrega.Location = new Point(663, 74);
            lbEntrega.Name = "lbEntrega";
            lbEntrega.Size = new Size(98, 23);
            lbEntrega.TabIndex = 27;
            lbEntrega.Text = "Entrega:";
            // 
            // lbTotalRepuestos
            // 
            lbTotalRepuestos.AutoSize = true;
            lbTotalRepuestos.Location = new Point(280, 584);
            lbTotalRepuestos.Name = "lbTotalRepuestos";
            lbTotalRepuestos.Size = new Size(44, 20);
            lbTotalRepuestos.TabIndex = 21;
            lbTotalRepuestos.Text = "00.00";
            // 
            // lbTotalIVA
            // 
            lbTotalIVA.AutoSize = true;
            lbTotalIVA.Location = new Point(104, 605);
            lbTotalIVA.Name = "lbTotalIVA";
            lbTotalIVA.Size = new Size(44, 20);
            lbTotalIVA.TabIndex = 28;
            lbTotalIVA.Text = "00.00";
            // 
            // labelIVA
            // 
            labelIVA.Font = new Font("Consolas", 12F, FontStyle.Bold);
            labelIVA.ForeColor = Color.FromArgb(242, 39, 56);
            labelIVA.Location = new Point(41, 602);
            labelIVA.Name = "labelIVA";
            labelIVA.Size = new Size(62, 23);
            labelIVA.TabIndex = 29;
            labelIVA.Text = "IVA:";
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Consolas", 12F, FontStyle.Bold);
            labelTotal.ForeColor = Color.FromArgb(242, 39, 56);
            labelTotal.Location = new Point(21, 625);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(82, 26);
            labelTotal.TabIndex = 30;
            labelTotal.Text = "Total:";
            // 
            // frmGestionReparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1095, 660);
            Controls.Add(labelTotal);
            Controls.Add(labelIVA);
            Controls.Add(lbTotalIVA);
            Controls.Add(lbEntrega);
            Controls.Add(lbIngreso);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbTotalReparacion);
            Controls.Add(lbTotalServicios);
            Controls.Add(lbTotalRepuestos);
            Controls.Add(dgvReparacion);
            Controls.Add(btnCancelarReparacion);
            Controls.Add(btnNuevaReparacion);
            Controls.Add(AddTecnicopanel);
            Controls.Add(AddEquipopanel);
            Controls.Add(btnAddClientelpanel);
            Controls.Add(lbCEquipo);
            Controls.Add(lbCCliente);
            Controls.Add(lbCTecnico);
            Controls.Add(lbServicios);
            Controls.Add(label1);
            Controls.Add(btnGuardarReparacion);
            Controls.Add(cbEquipo);
            Controls.Add(cbCliente);
            Controls.Add(cbTecnico);
            Controls.Add(lbDiagnosticos);
            Controls.Add(richTextBoxDiagnosticos);
            Controls.Add(lbRepuestos);
            Controls.Add(checkedListBoxServicio);
            Controls.Add(checkedListBoxRepuesto);
            ForeColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestionReparacion";
            Text = "Gestión de Reparación";
            Load += frmGestionReparacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReparacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxRepuesto;
        private CheckedListBox checkedListBoxServicio;
        private Label lbRepuestos;
        private RichTextBox richTextBoxDiagnosticos;
        private Label lbDiagnosticos;
        private ComboBox cbTecnico;
        private ComboBox cbCliente;
        private ComboBox cbEquipo;
        private Button btnGuardarReparacion;
        private Label label1;
        private Label lbServicios;
        private Label lbCTecnico;
        private Label lbCCliente;
        private Label lbCEquipo;
        private Button btnAddClientelpanel;
        private Button AddEquipopanel;
        private Button AddTecnicopanel;
        private Button btnNuevaReparacion;
        private Button btnCancelarReparacion;
        private DataGridView dgvReparacion;
        private Label lbTotalServicios;
        private Label lbTotalReparacion;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lbIngreso;
        private Label lbEntrega;
        private Label lbTotalRepuestos;
        private Label lbTotalIVA;
        private Label labelIVA;
        private Label labelTotal;
    }
}
