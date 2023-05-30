using PPAI_2023.Gestores;
using PPAI_2023.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023
{
    public partial class PantRegistrarRespuesta : Form
    {
        private string validacionActual = null;
        private GestorRegistrarRespuesta gestorRegistrarRespuesta = null;

        public PantRegistrarRespuesta(GestorRegistrarRespuesta gestorRegistrarRespuesta)
        {
            InitializeComponent();
            this.gestorRegistrarRespuesta = gestorRegistrarRespuesta;
        }

        public void HabilitarPantalla()
        {
            this.Show();
        }

        public void MostrarDatosLlamada(string nombreCliente, string nombreCategoria, string nombreOpcion, string nombreSubopcion)
        {
            HabilitarPantalla();

            txtNombreCliente.Text = nombreCliente;
            txtNombreCategoria.Text = nombreCategoria;
            txtNombreOpcion.Text = nombreOpcion;
            txtNombreSubopcion.Text = nombreSubopcion;
        }

        public void MostrarValidacion(string nombreValidacion)
        {
            validacionActual = nombreValidacion;
            if (nombreValidacion == "fechaNacimiento")
            {
                pnlFechaNacimiento.Visible = true;
            }
            else if (nombreValidacion == "codigoPostal")
            {
                pnlCodigoPostal.Visible = true;
            }
        }

        public void OcultarValidacion()
        {

        }

        private void TomarRespuestaValidacion(object sender, EventArgs e)
        {
            if (validacionActual == "fechaNacimiento")
            {
                btnComprobarFechaNacimiento.Enabled = false;
                dtFechaNacimiento.Enabled = false;

                var fechaNacimientroString = dtFechaNacimiento.Value.ToString("dd-MM-yyyy");
                gestorRegistrarRespuesta.TomarRespuestaValidacion(validacionActual, fechaNacimientroString);
            }
            else if (validacionActual == "codigoPostal")
            {
                txtCodigoPostal.Enabled = false;
                btnComprobarCodigoPostal.Enabled = false;

                var codigoPostal = txtCodigoPostal.Text;
                gestorRegistrarRespuesta.TomarRespuestaValidacion(validacionActual, codigoPostal);
            }
        }

        public void SolicitarDescripcionDeRespuesta()
        {
            txtRespuestaOperador.Enabled = true;
        }

        public void SolicitarAccionARealizar(List<string> accionesARealizar)
        {
            cbAccionARealizar.Enabled = true;
            btnAceptarRespuestaOperador.Enabled = true;

            cbAccionARealizar.DataSource = accionesARealizar;
        }

        public void MostrarMensajeValidacionErronea()
        {
            MessageBox.Show("El dato ingresado es incorrecto.", "Atención");
            Application.Exit();
        }

        private void TomarDescripcionDeRespuesta(object sender, EventArgs e)
        {
            var descripcionDeRespuesta = txtRespuestaOperador.Text;
            var accionARealizarSeleccionada = (string)cbAccionARealizar.SelectedItem;
            gestorRegistrarRespuesta.TomarDescripcionDeRespuesta(descripcionDeRespuesta, accionARealizarSeleccionada);
        }

        public void SolicitarConfirmacion()
        {
            var respuesta = MessageBox.Show("Por favor confirme la operacion a realizar", "Confirmacion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                TomarConfirmacion();
            }
        }

        public void TomarConfirmacion()
        {
            gestorRegistrarRespuesta.TomarConfirmacion();
        }

        public void InformarAccionRealizadaConExito()
        {
            MessageBox.Show("La accion ha sido realizada con exito");
        }
    }
}
