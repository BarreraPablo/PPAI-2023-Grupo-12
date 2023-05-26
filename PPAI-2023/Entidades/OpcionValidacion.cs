using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class OpcionValidacion
    {
        public bool Correcta { get; set; }
        private string Descripcion;

        public string GetDescripcion => Descripcion;
    }
}
