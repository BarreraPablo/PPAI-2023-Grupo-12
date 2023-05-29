using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Estado
    {
        private string nombre;

        public string Nombre
        {
            set { nombre = value; }
        }

        public string GetNombre => nombre;

        public bool EsEnCurso()
        {
            return nombre == "En Curso";
        }

        public bool EsFinalizada()
        {
            return nombre == "Finalizada";
        }
    }
}
