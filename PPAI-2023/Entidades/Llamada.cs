using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;

        public string DescripcionOperador
        {
            get { return descripcionOperador; }
        }

        private string detalleAccionRequerida;

        public string DetalleAccionRequerida
        {
            get { return detalleAccionRequerida; }
            set { detalleAccionRequerida = value; }
        }

        private TimeSpan duracion;

        public TimeSpan Duracion
        {
            get { return duracion; }
        }

        private bool encuestaEnviada;

        public bool EncuestaEnviada
        {
            get { return encuestaEnviada; }
            set { encuestaEnviada = value; }
        }

        private string observacionAuditor;

        public string ObservacionAuditor
        {
            get { return observacionAuditor; }
            set { observacionAuditor = value; }
        }

        private Accion accionRequerida;

        public Accion AccionRequerida
        {
            get { return accionRequerida; }
            set { accionRequerida = value; }
        }

        private List<CambioEstado> cambioEstado;

        public List<CambioEstado> CambioEstado
        {
            get { return cambioEstado; }
            set { cambioEstado = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private SubOpcionLlamada subOpcionLlamada;

        public SubOpcionLlamada SubOpcionLlamada
        {
            get { return subOpcionLlamada; }
        }

        private OpcionLlamada opcionLlamada;

        public OpcionLlamada OpcionLlamada
        {
            set { opcionLlamada = value; }
        }

        public void SetSubOpcionLlamada(SubOpcionLlamada subOpcionLlamadaASetear)
        {
            this.subOpcionLlamada = subOpcionLlamadaASetear;
        }

        public void SetOpcionLlamada(OpcionLlamada opcionLlamadaSeleccionada)
        {
            this.OpcionLlamada = opcionLlamadaSeleccionada;
        }

        public void SetEstadoActual(DateTime fechaHoraActual, Estado estadoPorAsignar)
        {
            var nuevoCambioEstado = new CambioEstado
            {
                FechaHoraInicio = fechaHoraActual,
                Estado = estadoPorAsignar
            };

            cambioEstado.Add(nuevoCambioEstado);
        }

        public void SetDuracion(TimeSpan duracion)
        {
            this.duracion = duracion;
        }

        public string GetNombreClienteDeLlamada()
        {
            return Cliente.GetNombre();
        }

        public void SetDescripcionOperador(string descripcion)
        {
            this.descripcionOperador = descripcion;
        }

        public void CalcularDuracion()
        {
            var fechaHoraInicioCambioEstadoFinalizada = ObtenerCambioEstadoFinalizada().GetFechaHoraInicio();
            var fechaHoraInicioCambioEstadoEnCurso = ObtenerCambioEstadoEnCurso().GetFechaHoraInicio();

            var duracion = fechaHoraInicioCambioEstadoFinalizada.Subtract(fechaHoraInicioCambioEstadoEnCurso);

            SetDuracion(duracion);
        }

        public CambioEstado ObtenerCambioEstadoFinalizada()
        {
            return CambioEstado.First(c => c.EsFinalizada());
        }

        public CambioEstado ObtenerCambioEstadoEnCurso()
        {
            return CambioEstado.First(c => c.EsEnCurso());
        }
    }
}
