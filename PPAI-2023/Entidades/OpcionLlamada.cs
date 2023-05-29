using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class OpcionLlamada
    {
        private string audioMensajeSubopciones;

        public string AudioMensajeSubopciones
        {
            get { return audioMensajeSubopciones; }
            set { audioMensajeSubopciones = value; }
        }

        private string mensajeSubopciones;

        public string MensajeSubopciones
        {
            get { return mensajeSubopciones; }
            set { mensajeSubopciones = value; }
        }

        private string nombre;

        public string Nombre
        {
            set { nombre = value; }
        }

        public string GetNombre()
        {
            return nombre;
        }

        private int nroOrden;

        public int NroOrden
        {
            get { return nroOrden; }
            set { nroOrden = value; }
        }

        private List<SubOpcionLlamada> subopcionLlamada;

        public List<SubOpcionLlamada> SubopcionLlamada
        {
            get { return subopcionLlamada; }
            set { subopcionLlamada = value; }
        }

        private List<Validacion> validacionesRequeridas;

        public List<Validacion> ValidacionesRequeridas
        {
            get { return validacionesRequeridas; }
            set { validacionesRequeridas = value; }
        }

    }
}
