using System.Drawing;
using System.Windows.Forms;

namespace ReparacionesMovil
{
    partial class frmLoginUsuario : Form
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
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnIniciarSeccion = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(13, 13, 13);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.FromArgb(242, 39, 56);
            txtUsuario.Location = new Point(237, 75);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(169, 38);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.FromArgb(13, 13, 13);
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.ForeColor = Color.FromArgb(242, 39, 56);
            txtContrasenia.Location = new Point(237, 133);
            txtContrasenia.Margin = new Padding(3, 2, 3, 2);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(169, 38);
            txtContrasenia.TabIndex = 1;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(242, 39, 56);
            label1.Location = new Point(122, 84);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(242, 39, 56);
            label2.Location = new Point(101, 142);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnIniciarSeccion
            // 
            btnIniciarSeccion.BackColor = Color.FromArgb(242, 39, 56);
            btnIniciarSeccion.FlatStyle = FlatStyle.Popup;
            btnIniciarSeccion.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            btnIniciarSeccion.ForeColor = Color.White;
            btnIniciarSeccion.Location = new Point(197, 229);
            btnIniciarSeccion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSeccion.Name = "btnIniciarSeccion";
            btnIniciarSeccion.Size = new Size(134, 22);
            btnIniciarSeccion.TabIndex = 4;
            btnIniciarSeccion.Text = "Iniciar Sesión";
            btnIniciarSeccion.UseVisualStyleBackColor = false;
            btnIniciarSeccion.Click += btnIniciarSeccion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnIniciarSeccion);
            groupBox1.Controls.Add(txtContrasenia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(242, 39, 56);
            groupBox1.Location = new Point(159, 93);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(550, 319);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Usuario";
            // 
            // frmLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(876, 528);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLoginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Label label1;
        private Label label2;
        private Button btnIniciarSeccion;
        private GroupBox groupBox1;
    }
}
