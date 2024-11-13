namespace CapaPresentacion
{
    partial class frmGestionEquipos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbTitulo = new Label();
            dgvEquipos = new DataGridView();
            PanelFormularioEquipo = new Panel();
            gbResgistroEquipo = new GroupBox();
            cmbEstado = new ComboBox();
            cbClientes = new ComboBox();
            dateIngreso = new DateTimePicker();
            lbEstado = new Label();
            IbIdCliente = new Label();
            lbFechaIngreso = new Label();
            txtSerie = new TextBox();
            lbTipo = new Label();
            txtTipo = new TextBox();
            lbNumeroSerie = new Label();
            btnGuardarEquipo = new Button();
            btnNuevoEquipo = new Button();
            btnCancelarEquipo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            PanelFormularioEquipo.SuspendLayout();
            gbResgistroEquipo.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.FromArgb(242, 39, 56);
            lbTitulo.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.AntiqueWhite;
            lbTitulo.Location = new Point(8, 4);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(319, 36);
            lbTitulo.TabIndex = 3;
            lbTitulo.Text = "Registro de Equipos";
            // 
            // dgvEquipos
            // 
            dgvEquipos.BackgroundColor = Color.FromArgb(13, 13, 13);
            dgvEquipos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle1.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 14, 32);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEquipos.EnableHeadersVisualStyles = false;
            dgvEquipos.GridColor = SystemColors.ButtonShadow;
            dgvEquipos.Location = new Point(432, 72);
            dgvEquipos.Margin = new Padding(2);
            dgvEquipos.Name = "dgvEquipos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(242, 39, 56);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(649, 579);
            dgvEquipos.TabIndex = 5;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // PanelFormularioEquipo
            // 
            PanelFormularioEquipo.BackColor = Color.FromArgb(13, 13, 13);
            PanelFormularioEquipo.Controls.Add(gbResgistroEquipo);
            PanelFormularioEquipo.Controls.Add(btnGuardarEquipo);
            PanelFormularioEquipo.Controls.Add(btnNuevoEquipo);
            PanelFormularioEquipo.Controls.Add(btnCancelarEquipo);
            PanelFormularioEquipo.Location = new Point(11, 72);
            PanelFormularioEquipo.Margin = new Padding(4);
            PanelFormularioEquipo.Name = "PanelFormularioEquipo";
            PanelFormularioEquipo.Size = new Size(416, 579);
            PanelFormularioEquipo.TabIndex = 0;
            // 
            // gbResgistroEquipo
            // 
            gbResgistroEquipo.Controls.Add(cmbEstado);
            gbResgistroEquipo.Controls.Add(lbTitulo);
            gbResgistroEquipo.Controls.Add(cbClientes);
            gbResgistroEquipo.Controls.Add(dateIngreso);
            gbResgistroEquipo.Controls.Add(lbEstado);
            gbResgistroEquipo.Controls.Add(IbIdCliente);
            gbResgistroEquipo.Controls.Add(lbFechaIngreso);
            gbResgistroEquipo.Controls.Add(txtSerie);
            gbResgistroEquipo.Controls.Add(lbTipo);
            gbResgistroEquipo.Controls.Add(txtTipo);
            gbResgistroEquipo.Controls.Add(lbNumeroSerie);
            gbResgistroEquipo.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbResgistroEquipo.ForeColor = Color.FromArgb(115, 14, 32);
            gbResgistroEquipo.Location = new Point(18, 59);
            gbResgistroEquipo.Margin = new Padding(4, 2, 4, 2);
            gbResgistroEquipo.Name = "gbResgistroEquipo";
            gbResgistroEquipo.Padding = new Padding(4, 2, 4, 2);
            gbResgistroEquipo.Size = new Size(386, 452);
            gbResgistroEquipo.TabIndex = 8;
            gbResgistroEquipo.TabStop = false;
            gbResgistroEquipo.Text = "Registro Equipos";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(18, 18, 18);
            cmbEstado.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstado.ForeColor = Color.FromArgb(242, 39, 56);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Seleccione", "Recibido", "En Reparacion", "Reparado", "Entregado" });
            cmbEstado.Location = new Point(109, 334);
            cmbEstado.Margin = new Padding(4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(243, 44);
            cmbEstado.TabIndex = 12;
            // 
            // cbClientes
            // 
            cbClientes.BackColor = Color.FromArgb(18, 18, 18);
            cbClientes.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbClientes.ForeColor = Color.FromArgb(242, 39, 56);
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(32, 91);
            cbClientes.Margin = new Padding(4);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(319, 36);
            cbClientes.TabIndex = 11;
            // 
            // dateIngreso
            // 
            dateIngreso.BackColor = Color.FromArgb(13, 13, 13);
            dateIngreso.CalendarFont = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateIngreso.CalendarForeColor = Color.AntiqueWhite;
            dateIngreso.CalendarMonthBackground = Color.FromArgb(13, 13, 13);
            dateIngreso.CalendarTitleBackColor = Color.FromArgb(115, 14, 32);
            dateIngreso.CalendarTitleForeColor = Color.FromArgb(242, 39, 56);
            dateIngreso.CalendarTrailingForeColor = Color.AntiqueWhite;
            dateIngreso.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateIngreso.ForeColor = Color.AntiqueWhite;
            dateIngreso.Format = DateTimePickerFormat.Short;
            dateIngreso.Location = new Point(189, 404);
            dateIngreso.Margin = new Padding(4);
            dateIngreso.Name = "dateIngreso";
            dateIngreso.Size = new Size(163, 27);
            dateIngreso.TabIndex = 10;
            dateIngreso.Value = new DateTime(2024, 8, 1, 0, 0, 0, 0);
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbEstado.ForeColor = Color.AntiqueWhite;
            lbEstado.Location = new Point(30, 351);
            lbEstado.Margin = new Padding(2, 0, 2, 0);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(80, 22);
            lbEstado.TabIndex = 8;
            lbEstado.Text = "Estado:";
            // 
            // IbIdCliente
            // 
            IbIdCliente.AutoSize = true;
            IbIdCliente.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            IbIdCliente.ForeColor = Color.AntiqueWhite;
            IbIdCliente.Location = new Point(31, 65);
            IbIdCliente.Margin = new Padding(2, 0, 2, 0);
            IbIdCliente.Name = "IbIdCliente";
            IbIdCliente.Size = new Size(90, 22);
            IbIdCliente.TabIndex = 0;
            IbIdCliente.Text = "Cliente:";
            // 
            // lbFechaIngreso
            // 
            lbFechaIngreso.AutoSize = true;
            lbFechaIngreso.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbFechaIngreso.ForeColor = Color.AntiqueWhite;
            lbFechaIngreso.Location = new Point(32, 410);
            lbFechaIngreso.Margin = new Padding(2, 0, 2, 0);
            lbFechaIngreso.Name = "lbFechaIngreso";
            lbFechaIngreso.Size = new Size(150, 22);
            lbFechaIngreso.TabIndex = 6;
            lbFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // txtSerie
            // 
            txtSerie.BackColor = Color.FromArgb(18, 18, 18);
            txtSerie.BorderStyle = BorderStyle.None;
            txtSerie.ForeColor = Color.FromArgb(242, 39, 56);
            txtSerie.Location = new Point(32, 172);
            txtSerie.Margin = new Padding(4);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(319, 39);
            txtSerie.TabIndex = 4;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbTipo.ForeColor = Color.AntiqueWhite;
            lbTipo.Location = new Point(32, 248);
            lbTipo.Margin = new Padding(2, 0, 2, 0);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(60, 22);
            lbTipo.TabIndex = 1;
            lbTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(18, 18, 18);
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.ForeColor = Color.FromArgb(242, 39, 56);
            txtTipo.Location = new Point(108, 248);
            txtTipo.Margin = new Padding(4);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(244, 39);
            txtTipo.TabIndex = 5;
            // 
            // lbNumeroSerie
            // 
            lbNumeroSerie.AutoSize = true;
            lbNumeroSerie.Font = new Font("Consolas", 10.8F, FontStyle.Bold);
            lbNumeroSerie.ForeColor = Color.AntiqueWhite;
            lbNumeroSerie.Location = new Point(32, 146);
            lbNumeroSerie.Margin = new Padding(2, 0, 2, 0);
            lbNumeroSerie.Name = "lbNumeroSerie";
            lbNumeroSerie.Size = new Size(100, 22);
            lbNumeroSerie.TabIndex = 2;
            lbNumeroSerie.Text = "N° Serie:";
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.BackColor = Color.FromArgb(13, 13, 13);
            btnGuardarEquipo.Enabled = false;
            btnGuardarEquipo.FlatStyle = FlatStyle.Flat;
            btnGuardarEquipo.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnGuardarEquipo.ForeColor = Color.AntiqueWhite;
            btnGuardarEquipo.Location = new Point(134, 518);
            btnGuardarEquipo.Margin = new Padding(4);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(121, 40);
            btnGuardarEquipo.TabIndex = 4;
            btnGuardarEquipo.Text = "Guardar";
            btnGuardarEquipo.UseVisualStyleBackColor = false;
            btnGuardarEquipo.Click += btnGuardarEquipo_Click_1;
            // 
            // btnNuevoEquipo
            // 
            btnNuevoEquipo.BackColor = Color.FromArgb(115, 14, 32);
            btnNuevoEquipo.FlatStyle = FlatStyle.Popup;
            btnNuevoEquipo.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnNuevoEquipo.ForeColor = Color.AntiqueWhite;
            btnNuevoEquipo.Location = new Point(18, 12);
            btnNuevoEquipo.Margin = new Padding(4);
            btnNuevoEquipo.Name = "btnNuevoEquipo";
            btnNuevoEquipo.Size = new Size(121, 40);
            btnNuevoEquipo.TabIndex = 0;
            btnNuevoEquipo.Text = "Nuevo";
            btnNuevoEquipo.UseVisualStyleBackColor = false;
            btnNuevoEquipo.Click += btnNuevo_Click;
            // 
            // btnCancelarEquipo
            // 
            btnCancelarEquipo.BackColor = Color.FromArgb(242, 39, 56);
            btnCancelarEquipo.FlatStyle = FlatStyle.Popup;
            btnCancelarEquipo.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnCancelarEquipo.ForeColor = Color.AntiqueWhite;
            btnCancelarEquipo.Location = new Point(282, 518);
            btnCancelarEquipo.Margin = new Padding(4);
            btnCancelarEquipo.Name = "btnCancelarEquipo";
            btnCancelarEquipo.Size = new Size(121, 40);
            btnCancelarEquipo.TabIndex = 1;
            btnCancelarEquipo.Text = "Cancelar";
            btnCancelarEquipo.UseVisualStyleBackColor = false;
            btnCancelarEquipo.Visible = false;
            btnCancelarEquipo.Click += btnCancelar_Click;
            // 
            // frmGestionEquipos
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1095, 660);
            Controls.Add(dgvEquipos);
            Controls.Add(PanelFormularioEquipo);
            ForeColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmGestionEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Equipos";
            Load += frmGestionEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            PanelFormularioEquipo.ResumeLayout(false);
            gbResgistroEquipo.ResumeLayout(false);
            gbResgistroEquipo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbTitulo;
        private DataGridView dgvEquipos;
        private Panel PanelFormularioEquipo;
        private GroupBox gbResgistroEquipo;
        private Label IbIdCliente;
        private TextBox txtSerie;
        private Label lbTipo;
        private TextBox txtTipo;
        private Label lbNumeroSerie;
        private Button btnGuardarEquipo;
        private Button btnNuevoEquipo;
        private Button btnCancelarEquipo;
        private Label lbEstado;
        private DateTimePicker dateIngreso;
        private Label lbFechaIngreso;
        private ComboBox cbClientes;
        private ComboBox cmbEstado;
    }
}
