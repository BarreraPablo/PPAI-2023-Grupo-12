using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023.Gestores
{
    public class GestorRegistrarRespuesta
    {
        private Llamada llamada;
        private CategoriaLlamada categoria;
        private OpcionLlamada opcion;
        private SubOpcionLlamada subOpcionLlamada;
        private Estado estadoEnCurso;

        private Queue<(int nroOrden, string nombreValidacion)> queueValidaciones;

        private PantRegistrarRespuesta pantRegistrarRespuesta = null;
        private GestorRegistrarAccionRequerida gestorRegistrarAccionRequerida;

        private string respuestaOperador = null;
        private string accionARealizarSeleccionada = null;

        public GestorRegistrarRespuesta(GestorRegistrarAccionRequerida gestorRegistrarAccionRequerida)
        {
            pantRegistrarRespuesta = new PantRegistrarRespuesta(this);
            this.gestorRegistrarAccionRequerida = gestorRegistrarAccionRequerida;
        }

        public void OpcionRegistrarseConOperador(Llamada llamada, CategoriaLlamada categoria, OpcionLlamada opcion, SubOpcionLlamada subOpcionLlamada)
        {
            this.llamada = llamada;
            this.categoria = categoria;
            this.opcion = opcion;
            this.subOpcionLlamada = subOpcionLlamada;

            SetEstadoEnCurso();
            var (nombreCliente, nombreCategoria, nombreOpcion, nombreSubopcion) = ObtenerDatosLlamada();
            pantRegistrarRespuesta.MostrarDatosLlamada(nombreCliente, nombreCategoria, nombreOpcion, nombreSubopcion);
            ObtenerValidacionesParaOpcionOSubopcion();
        }

        private void SetEstadoEnCurso()
        {
            estadoEnCurso = BuscarEstadoParaAsignar();
            var fechaHoraActual = GetFechaYHoraActual();
            llamada.SetEstadoActual(fechaHoraActual, estadoEnCurso);
        }

        private Estado BuscarEstadoParaAsignar()
        {
            foreach (var estado in Data.Estados)
            {
                if(estado.EsEnCurso())
                {
                    return estado;
                }
            }

            return null;
        }

        private DateTime GetFechaYHoraActual()
        {
            return DateTime.Now;
        }

        private (string, string, string, string) ObtenerDatosLlamada()
        {
            var nombreCliente = llamada.GetNombreClienteDeLlamada();
            var opcionNombre = opcion.GetNombre();
            var subOpcionNombre = subOpcionLlamada.GetNombre();
            var categoriaSeleccionada = categoria.GetNombre();

            return (nombreCliente, categoriaSeleccionada, opcionNombre, subOpcionNombre);
        }


        private void ObtenerValidacionesParaOpcionOSubopcion()
        {
            List<(int nroOrden, string nombreValidacion)> validaciones = null;
            if (subOpcionLlamada != null)
            {
                validaciones = subOpcionLlamada.ObtenerValidaciones();
            } else
            {
                // validaciones = opcion.ObtenerValidaciones(); No vamos a codificar esta alternativa
            }

            var validacionesOrdenadas = validaciones.OrderBy(v => v.nroOrden);
            queueValidaciones = new Queue<(int nroOrden, string nombreValidacion)>(validacionesOrdenadas);

            MostrarProximaValidacion();
        }

        private void MostrarProximaValidacion()
        {
            var siguienteValidacion = queueValidaciones.Dequeue();
            pantRegistrarRespuesta.MostrarValidacion(siguienteValidacion.nombreValidacion);
        }

        public void TomarRespuestaValidacion(string nombreValidacion, string valor)
        {
            CorroborarValidacion(nombreValidacion, valor);
        }

        public void CorroborarValidacion(string nombreValidacion, string valor)
        {
            var resultadoValidacion = llamada.Cliente.EjecutarValidacion(nombreValidacion, valor);

            if (resultadoValidacion)
            {
                if (HayMasValidacionesPorMostrar())
                {
                    MostrarProximaValidacion();
                }
                else
                {
                    pantRegistrarRespuesta.SolicitarDescripcionDeRespuesta();

                    var acciones = ObtenerAcciones();

                    var accionesParaPantalla = acciones.Select(a => a.GetDescripcion()).ToList();

                    pantRegistrarRespuesta.SolicitarAccionARealizar(accionesParaPantalla);
                }
            }
            else
            {
                pantRegistrarRespuesta.MostrarMensajeValidacionErronea();
                FinCU();
            }
        }

        public bool HayMasValidacionesPorMostrar()
        {
            return queueValidaciones.Count() > 0;
        }

        public List<Accion> ObtenerAcciones()
        {
            return Data.Acciones;
        }

        public Accion ObtenerAccionPorDescripcion(string descripcionABuscar)
        {
            return ObtenerAcciones().Single(a => a.GetDescripcion() == descripcionABuscar);
        }

        public void TomarDescripcionDeRespuesta(string descripcion, string accionARealizar)
        {
            this.respuestaOperador = descripcion;
            this.accionARealizarSeleccionada = accionARealizar;

            pantRegistrarRespuesta.SolicitarConfirmacion();
        }

        public void TomarConfirmacion()
        {
            LlamarCURegistrarAccionRequerida();
            RegistrarLlamadaFinalizada();
            FinCU();
        }

        public void RegistrarLlamadaFinalizada()
        {
            RegistrarRespuestaDelOperador();
            EstablecerLlamadaComoFinalizada();
            llamada.CalcularDuracion();
            EstablecerOpcionOSubOpcionSeleccionada();
        }

        public void LlamarCURegistrarAccionRequerida()
        {
            var accionParaRegistrar = ObtenerAccionPorDescripcion(this.accionARealizarSeleccionada);

            gestorRegistrarAccionRequerida.RegistrarAccionRequerida(accionParaRegistrar);

            pantRegistrarRespuesta.InformarAccionRealizadaConExito();
        }

        public void EstablecerLlamadaComoFinalizada()
        {
            var accionFinalizada = ObtenerEstadoFinalizada();
            var fechaHoraActual = GetFechaYHoraActual();
            llamada.SetEstadoActual(fechaHoraActual, accionFinalizada);
        }

        public void RegistrarRespuestaDelOperador()
        {
            var descripcionOperador = this.respuestaOperador;
            llamada.SetDescripcionOperador(descripcionOperador);
        }

        public Estado ObtenerEstadoFinalizada()
        {
            return Data.Estados.First(e => e.EsFinalizada());
        }

        public void EstablecerOpcionOSubOpcionSeleccionada()
        {
            if (this.subOpcionLlamada != null)
            {
                llamada.SetSubOpcionLlamada(this.subOpcionLlamada);
            } else
            {
                llamada.SetOpcionLlamada(this.opcion);
            }
        }

        public void TomarCancelacion()
        {
            var estadoCancelada = ObtenerEstadoCancelada();
            var fechaHoraActual = GetFechaYHoraActual();
            llamada.SetEstadoActual(fechaHoraActual, estadoCancelada);
            FinCU();
        }

        public Estado ObtenerEstadoCancelada()
        {
            return Data.Estados.First(e => e.EsFinalizada());
        }

        public void FinCU()
        {
            Application.Exit();
        }
    }
}
