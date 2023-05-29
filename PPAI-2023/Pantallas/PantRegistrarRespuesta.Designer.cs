
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.lblNombreOpcion = new System.Windows.Forms.Label();
            this.lblNombreSubopcion = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreOpcion = new System.Windows.Forms.TextBox();
            this.txtNombreSubopcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlCodigoPostal = new System.Windows.Forms.Panel();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.btnComprobarCodigoPostal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFechaNacimiento = new System.Windows.Forms.Panel();
            this.btnComprobarFechaNacimiento = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccionARealizar = new System.Windows.Forms.ComboBox();
            this.btnAceptarRespuestaOperador = new System.Windows.Forms.Button();
            this.txtRespuestaOperador = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlCodigoPostal.SuspendLayout();
            this.pnlFechaNacimiento.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(47, 45);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(92, 15);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre cliente:";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(33, 79);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(106, 15);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre categoria:";
            // 
            // lblNombreOpcion
            // 
            this.lblNombreOpcion.AutoSize = true;
            this.lblNombreOpcion.Location = new System.Drawing.Point(45, 113);
            this.lblNombreOpcion.Name = "lblNombreOpcion";
            this.lblNombreOpcion.Size = new System.Drawing.Size(94, 15);
            this.lblNombreOpcion.TabIndex = 2;
            this.lblNombreOpcion.Text = "Nombre opcion:";
            // 
            // lblNombreSubopcion
            // 
            this.lblNombreSubopcion.AutoSize = true;
            this.lblNombreSubopcion.Location = new System.Drawing.Point(21, 147);
            this.lblNombreSubopcion.Name = "lblNombreSubopcion";
            this.lblNombreSubopcion.Size = new System.Drawing.Size(118, 15);
            this.lblNombreSubopcion.TabIndex = 3;
            this.lblNombreSubopcion.Text = "Nombre sub-opcion:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(145, 42);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(159, 23);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Enabled = false;
            this.txtNombreCategoria.Location = new System.Drawing.Point(145, 76);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(159, 23);
            this.txtNombreCategoria.TabIndex = 5;
            // 
            // txtNombreOpcion
            // 
            this.txtNombreOpcion.Enabled = false;
            this.txtNombreOpcion.Location = new System.Drawing.Point(145, 110);
            this.txtNombreOpcion.Name = "txtNombreOpcion";
            this.txtNombreOpcion.Size = new System.Drawing.Size(159, 23);
            this.txtNombreOpcion.TabIndex = 6;
            // 
            // txtNombreSubopcion
            // 
            this.txtNombreSubopcion.Enabled = false;
            this.txtNombreSubopcion.Location = new System.Drawing.Point(145, 144);
            this.txtNombreSubopcion.Name = "txtNombreSubopcion";
            this.txtNombreSubopcion.Size = new System.Drawing.Size(159, 23);
            this.txtNombreSubopcion.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtNombreSubopcion);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.txtNombreOpcion);
            this.groupBox1.Controls.Add(this.lblNombreCategoria);
            this.groupBox1.Controls.Add(this.txtNombreCategoria);
            this.groupBox1.Controls.Add(this.lblNombreOpcion);
            this.groupBox1.Controls.Add(this.lblNombreSubopcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 219);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos llamada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCodigoPostal);
            this.groupBox2.Controls.Add(this.pnlFechaNacimiento);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 257);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validaciones";
            // 
            // pnlCodigoPostal
            // 
            this.pnlCodigoPostal.Controls.Add(this.txtCodigoPostal);
            this.pnlCodigoPostal.Controls.Add(this.btnComprobarCodigoPostal);
            this.pnlCodigoPostal.Controls.Add(this.label1);
            this.pnlCodigoPostal.Location = new System.Drawing.Point(21, 133);
            this.pnlCodigoPostal.Name = "pnlCodigoPostal";
            this.pnlCodigoPostal.Size = new System.Drawing.Size(275, 105);
            this.pnlCodigoPostal.TabIndex = 3;
            this.pnlCodigoPostal.Visible = false;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(18, 37);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(198, 23);
            this.txtCodigoPostal.TabIndex = 3;
            // 
            // btnComprobarCodigoPostal
            // 
            this.btnComprobarCodigoPostal.Location = new System.Drawing.Point(82, 69);
            this.btnComprobarCodigoPostal.Name = "btnComprobarCodigoPostal";
            this.btnComprobarCodigoPostal.Size = new System.Drawing.Size(93, 23);
            this.btnComprobarCodigoPostal.TabIndex = 2;
            this.btnComprobarCodigoPostal.Text = "Comprobar";
            this.btnComprobarCodigoPostal.UseVisualStyleBackColor = true;
            this.btnComprobarCodigoPostal.Click += new System.EventHandler(this.TomarRespuestaValidacion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el codigo postal del cliente:";
            // 
            // pnlFechaNacimiento
            // 
            this.pnlFechaNacimiento.Controls.Add(this.btnComprobarFechaNacimiento);
            this.pnlFechaNacimiento.Controls.Add(this.lblFechaNacimiento);
            this.pnlFechaNacimiento.Controls.Add(this.dtFechaNacimiento);
            this.pnlFechaNacimiento.Location = new System.Drawing.Point(21, 22);
            this.pnlFechaNacimiento.Name = "pnlFechaNacimiento";
            this.pnlFechaNacimiento.Size = new System.Drawing.Size(275, 105);
            this.pnlFechaNacimiento.TabIndex = 2;
            this.pnlFechaNacimiento.Visible = false;
            // 
            // btnComprobarFechaNacimiento
            // 
            this.btnComprobarFechaNacimiento.Location = new System.Drawing.Point(82, 69);
            this.btnComprobarFechaNacimiento.Name = "btnComprobarFechaNacimiento";
            this.btnComprobarFechaNacimiento.Size = new System.Drawing.Size(93, 23);
            this.btnComprobarFechaNacimiento.TabIndex = 2;
            this.btnComprobarFechaNacimiento.Text = "Comprobar";
            this.btnComprobarFechaNacimiento.UseVisualStyleBackColor = true;
            this.btnComprobarFechaNacimiento.Click += new System.EventHandler(this.TomarRespuestaValidacion);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(16, 13);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(228, 15);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Ingrese la fecha de nacimiento del cliente:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(16, 35);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtFechaNacimiento.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbAccionARealizar);
            this.groupBox3.Controls.Add(this.btnAceptarRespuestaOperador);
            this.groupBox3.Controls.Add(this.txtRespuestaOperador);
            this.groupBox3.Location = new System.Drawing.Point(476, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 298);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Acción a realizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Respuesta operador:";
            // 
            // cbAccionARealizar
            // 
            this.cbAccionARealizar.Enabled = false;
            this.cbAccionARealizar.FormattingEnabled = true;
            this.cbAccionARealizar.Location = new System.Drawing.Point(16, 226);
            this.cbAccionARealizar.Name = "cbAccionARealizar";
            this.cbAccionARealizar.Size = new System.Drawing.Size(214, 23);
            this.cbAccionARealizar.TabIndex = 6;
            // 
            // btnAceptarRespuestaOperador
            // 
            this.btnAceptarRespuestaOperador.Enabled = false;
            this.btnAceptarRespuestaOperador.Location = new System.Drawing.Point(159, 263);
            this.btnAceptarRespuestaOperador.Name = "btnAceptarRespuestaOperador";
            this.btnAceptarRespuestaOperador.Size = new System.Drawing.Size(93, 23);
            this.btnAceptarRespuestaOperador.TabIndex = 3;
            this.btnAceptarRespuestaOperador.Text = "Aceptar";
            this.btnAceptarRespuestaOperador.UseVisualStyleBackColor = true;
            this.btnAceptarRespuestaOperador.Click += new System.EventHandler(this.TomarDescripcionDeRespuesta);
            // 
            // txtRespuestaOperador
            // 
            this.txtRespuestaOperador.Enabled = false;
            this.txtRespuestaOperador.Location = new System.Drawing.Point(16, 42);
            this.txtRespuestaOperador.Multiline = true;
            this.txtRespuestaOperador.Name = "txtRespuestaOperador";
            this.txtRespuestaOperador.Size = new System.Drawing.Size(394, 145);
            this.txtRespuestaOperador.TabIndex = 5;
            // 
            // PantRegistrarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantRegistrarRespuesta";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlCodigoPostal.ResumeLayout(false);
            this.pnlCodigoPostal.PerformLayout();
            this.pnlFechaNacimiento.ResumeLayout(false);
            this.pnlFechaNacimiento.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

