using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class SubOpcionLlamada
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int nroOrder;

        public int NroOrder
        {
            get { return nroOrder; }
            set { nroOrder = value; }
        }

        private List<Validacion> validacionRequerida;

        public List<Validacion> ValidacionRequerida
        {
            get { return validacionRequerida; }
            set { validacionRequerida = value; }
        }

        public List<Validacion> ObtenerValidaciones()
        {
            if (ValidacionRequerida.Count() > 0)
            {
                return validacionRequerida;
            }
            return null;
        }
    }
}
