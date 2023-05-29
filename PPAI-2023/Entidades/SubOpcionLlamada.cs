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
            set { nombre = value; }
        }

        public string GetNombre()
        {
            return nombre;
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

        public List<(int nroOrden, string nombreValidacion)> ObtenerValidaciones()
        {
            if (TieneValidacion())
            {
                var resultados = new List<(int nroOrden, string nombre)>();
                foreach (var validacion in validacionRequerida)
                {
                    resultados.Add(validacion.GetDatosValidacion());
                }
                return resultados;
            }
            return new List<(int nroOrden, string nombreValidacion)>();
        }

        public bool TieneValidacion()
        {
            return validacionRequerida.Count() > 0;
        }
    }
}
