
namespace PPAI_2023
{
    partial class PantRegistrarRespuesta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreCliente = new System.Windows.Forms.Label();
            lblNombreCategoria = new System.Windows.Forms.Label();
            lblNombreOpcion = new System.Windows.Forms.Label();
            lblNombreSubopcion = new System.Windows.Forms.Label();
            txtNombreCliente = new System.Windows.Forms.TextBox();
            txtNombreCategoria = new System.Windows.Forms.TextBox();
            txtNombreOpcion = new System.Windows.Forms.TextBox();
            txtNombreSubopcion = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            pnlCodigoPostal = new System.Windows.Forms.Panel();
            txtCodigoPostal = new System.Windows.Forms.TextBox();
            btnComprobarCodigoPostal = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pnlFechaNacimiento = new System.Windows.Forms.Panel();
            btnComprobarFechaNacimiento = new System.Windows.Forms.Button();
            lblFechaNacimiento = new System.Windows.Forms.Label();
            dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbAccionARealizar = new System.Windows.Forms.ComboBox();
            btnAceptarRespuestaOperador = new System.Windows.Forms.Button();
            txtRespuestaOperador = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlCodigoPostal.SuspendLayout();
            pnlFechaNacimiento.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new System.Drawing.Point(47, 45);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(92, 15);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre cliente:";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new System.Drawing.Point(33, 79);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new System.Drawing.Size(106, 15);
            lblNombreCategoria.TabIndex = 1;
            lblNombreCategoria.Text = "Nombre categoria:";
            // 
            // lblNombreOpcion
            // 
            lblNombreOpcion.AutoSize = true;
            lblNombreOpcion.Location = new System.Drawing.Point(45, 113);
            lblNombreOpcion.Name = "lblNombreOpcion";
            lblNombreOpcion.Size = new System.Drawing.Size(94, 15);
            lblNombreOpcion.TabIndex = 2;
            lblNombreOpcion.Text = "Nombre opcion:";
            // 
            // lblNombreSubopcion
            // 
            lblNombreSubopcion.AutoSize = true;
            lblNombreSubopcion.Location = new System.Drawing.Point(21, 147);
            lblNombreSubopcion.Name = "lblNombreSubopcion";
            lblNombreSubopcion.Size = new System.Drawing.Size(118, 15);
            lblNombreSubopcion.TabIndex = 3;
            lblNombreSubopcion.Text = "Nombre sub-opcion:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new System.Drawing.Point(145, 42);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new System.Drawing.Size(159, 23);
            txtNombreCliente.TabIndex = 4;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Enabled = false;
            txtNombreCategoria.Location = new System.Drawing.Point(145, 76);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new System.Drawing.Size(159, 23);
            txtNombreCategoria.TabIndex = 5;
            // 
            // txtNombreOpcion
            // 
            txtNombreOpcion.Enabled = false;
            txtNombreOpcion.Location = new System.Drawing.Point(145, 110);
            txtNombreOpcion.Name = "txtNombreOpcion";
            txtNombreOpcion.Size = new System.Drawing.Size(159, 23);
            txtNombreOpcion.TabIndex = 6;
            // 
            // txtNombreSubopcion
            // 
            txtNombreSubopcion.Enabled = false;
            txtNombreSubopcion.Location = new System.Drawing.Point(145, 144);
            txtNombreSubopcion.Name = "txtNombreSubopcion";
            txtNombreSubopcion.Size = new System.Drawing.Size(159, 23);
            txtNombreSubopcion.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(txtNombreSubopcion);
            groupBox1.Controls.Add(lblNombreCliente);
            groupBox1.Controls.Add(txtNombreOpcion);
            groupBox1.Controls.Add(lblNombreCategoria);
            groupBox1.Controls.Add(txtNombreCategoria);
            groupBox1.Controls.Add(lblNombreOpcion);
            groupBox1.Controls.Add(lblNombreSubopcion);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(427, 219);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos llamada:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnlCodigoPostal);
            groupBox2.Controls.Add(pnlFechaNacimiento);
            groupBox2.Location = new System.Drawing.Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(427, 257);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Validaciones";
            // 
            // pnlCodigoPostal
            // 
            pnlCodigoPostal.Controls.Add(txtCodigoPostal);
            pnlCodigoPostal.Controls.Add(btnComprobarCodigoPostal);
            pnlCodigoPostal.Controls.Add(label1);
            pnlCodigoPostal.Location = new System.Drawing.Point(21, 133);
            pnlCodigoPostal.Name = "pnlCodigoPostal";
            pnlCodigoPostal.Size = new System.Drawing.Size(275, 105);
            pnlCodigoPostal.TabIndex = 3;
            pnlCodigoPostal.Visible = false;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new System.Drawing.Point(18, 37);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new System.Drawing.Size(198, 23);
            txtCodigoPostal.TabIndex = 3;
            // 
            // btnComprobarCodigoPostal
            // 
            btnComprobarCodigoPostal.Location = new System.Drawing.Point(82, 69);
            btnComprobarCodigoPostal.Name = "btnComprobarCodigoPostal";
            btnComprobarCodigoPostal.Size = new System.Drawing.Size(93, 23);
            btnComprobarCodigoPostal.TabIndex = 2;
            btnComprobarCodigoPostal.Text = "Comprobar";
            btnComprobarCodigoPostal.UseVisualStyleBackColor = true;
            btnComprobarCodigoPostal.Click += TomarRespuestaValidacion;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el codigo postal del cliente:";
            // 
            // pnlFechaNacimiento
            // 
            pnlFechaNacimiento.Controls.Add(btnComprobarFechaNacimiento);
            pnlFechaNacimiento.Controls.Add(lblFechaNacimiento);
            pnlFechaNacimiento.Controls.Add(dtFechaNacimiento);
            pnlFechaNacimiento.Location = new System.Drawing.Point(21, 22);
            pnlFechaNacimiento.Name = "pnlFechaNacimiento";
            pnlFechaNacimiento.Size = new System.Drawing.Size(275, 105);
            pnlFechaNacimiento.TabIndex = 2;
            pnlFechaNacimiento.Visible = false;
            // 
            // btnComprobarFechaNacimiento
            // 
            btnComprobarFechaNacimiento.Location = new System.Drawing.Point(82, 69);
            btnComprobarFechaNacimiento.Name = "btnComprobarFechaNacimiento";
            btnComprobarFechaNacimiento.Size = new System.Drawing.Size(93, 23);
            btnComprobarFechaNacimiento.TabIndex = 2;
            btnComprobarFechaNacimiento.Text = "Comprobar";
            btnComprobarFechaNacimiento.UseVisualStyleBackColor = true;
            btnComprobarFechaNacimiento.Click += TomarRespuestaValidacion;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new System.Drawing.Point(16, 13);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new System.Drawing.Size(228, 15);
            lblFechaNacimiento.TabIndex = 1;
            lblFechaNacimiento.Text = "Ingrese la fecha de nacimiento del cliente:";
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new System.Drawing.Point(16, 35);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            dtFechaNacimiento.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cbAccionARealizar);
            groupBox3.Controls.Add(btnAceptarRespuestaOperador);
            groupBox3.Controls.Add(txtRespuestaOperador);
            groupBox3.Location = new System.Drawing.Point(476, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(427, 298);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 204);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 15);
            label3.TabIndex = 8;
            label3.Text = "Acción a realizar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 15);
            label2.TabIndex = 7;
            label2.Text = "Respuesta operador:";
            // 
            // cbAccionARealizar
            // 
            cbAccionARealizar.Enabled = false;
            cbAccionARealizar.FormattingEnabled = true;
            cbAccionARealizar.Location = new System.Drawing.Point(16, 226);
            cbAccionARealizar.Name = "cbAccionARealizar";
            cbAccionARealizar.Size = new System.Drawing.Size(214, 23);
            cbAccionARealizar.TabIndex = 6;
            // 
            // btnAceptarRespuestaOperador
            // 
            btnAceptarRespuestaOperador.Enabled = false;
            btnAceptarRespuestaOperador.Location = new System.Drawing.Point(159, 263);
            btnAceptarRespuestaOperador.Name = "btnAceptarRespuestaOperador";
            btnAceptarRespuestaOperador.Size = new System.Drawing.Size(93, 23);
            btnAceptarRespuestaOperador.TabIndex = 3;
            btnAceptarRespuestaOperador.Text = "Aceptar";
            btnAceptarRespuestaOperador.UseVisualStyleBackColor = true;
            btnAceptarRespuestaOperador.Click += TomarDescripcionDeRespuesta;
            // 
            // txtRespuestaOperador
            // 
            txtRespuestaOperador.Enabled = false;
            txtRespuestaOperador.Location = new System.Drawing.Point(16, 42);
            txtRespuestaOperador.Multiline = true;
            txtRespuestaOperador.Name = "txtRespuestaOperador";
            txtRespuestaOperador.Size = new System.Drawing.Size(394, 145);
            txtRespuestaOperador.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_computer_icons_telephone_call_texas_state_university_parking_services_email_hanok_text_telephone_call_service1;
            pictureBox1.Location = new System.Drawing.Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(66, 42);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(84, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 15);
            label4.TabIndex = 9;
            label4.Text = "El cliente colgo la llamada";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new System.Drawing.Point(576, 358);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(242, 63);
            panel1.TabIndex = 11;
            panel1.Click += TomarCancelacion;
            // 
            // PantRegistrarRespuesta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(970, 563);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PantRegistrarRespuesta";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            pnlCodigoPostal.ResumeLayout(false);
            pnlCodigoPostal.PerformLayout();
            pnlFechaNacimiento.ResumeLayout(false);
            pnlFechaNacimiento.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Label lblNombreOpcion;
        private System.Windows.Forms.Label lblNombreSubopcion;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreOpcion;
        private System.Windows.Forms.TextBox txtNombreSubopcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Button btnComprobarFechaNacimiento;
        private System.Windows.Forms.Panel pnlCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Button btnComprobarCodigoPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAceptarRespuestaOperador;
        private System.Windows.Forms.TextBox txtRespuestaOperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccionARealizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

