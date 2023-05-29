using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Accion
    {
        private string descripcion;

        public string Descripcion
        {
            set { descripcion = value; }
        }

        public string GetDescripcion()
        {
            return descripcion;
        }
    }
}
