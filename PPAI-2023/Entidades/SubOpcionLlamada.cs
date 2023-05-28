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

        public string getDescripcionConSubopcion()
        {
            return nombre;
        }

        public List<Validacion> ObtenerValidaciones()
        {
            if (ValidacionRequerida.Count() > 0)
            {
                foreach (var validacion in ValidacionRequerida)
                {
                    validacionRequerida.Add(validacion);
                }
                return validacionRequerida;
            }
            return null;
        }
    }
}
