using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Validacion
    {
        private string audioMensajeValidacion;

        public string AudioMensajeValidacion
        {
            get { return audioMensajeValidacion; }
            set { audioMensajeValidacion = value; }
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

        public int NroOrder { get; set; }
        public List<OpcionValidacion> opcionesValidacion { get; set; }

        public int GetNroOrden()
        {
            return nroOrden;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public (int nroOrden, string nombreValidacion) GetDatosValidacion()
        {
            var nroOrden = GetNroOrden();
            var nombre = GetNombre();
            return (nroOrden, nombre);
        }
    }
}
