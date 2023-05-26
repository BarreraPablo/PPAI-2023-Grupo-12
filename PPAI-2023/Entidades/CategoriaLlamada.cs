using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class CategoriaLlamada
    {
        private string audioMensajeOpciones;

        public string AudioMensajeOpciones
        {
            set { audioMensajeOpciones = value; }
        }

        private string mensajeOpciones;

        public string MensajeOpciones
        {
            get { return mensajeOpciones; }
            set { mensajeOpciones = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int nroOrden;

        public int NroOrden
        {
            get { return nroOrden; }
            set { nroOrden = value; }
        }

        private List<OpcionLlamada> opcion;

        public List<OpcionLlamada> Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }


        public string GetAudioMensajeOpciones => audioMensajeOpciones;
    }
}
