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
            set { descripcionOperador = value; }
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
            set { duracion = value; }
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

        public void SetEstadoEnCurso(DateTime fechaHoraActual, Estado estadoPorAsignar)
        {
            var nuevoCambioEstado = new CambioEstado
            {
                FechaHoraInicio = fechaHoraActual,
                Estado = estadoPorAsignar
            };

            cambioEstado.Add(nuevoCambioEstado);
        }

        public string GetNombreClienteDeLlamada()
        {
            return Cliente.GetNombre();
        }
    }
}
