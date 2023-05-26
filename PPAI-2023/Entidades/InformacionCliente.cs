using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class InformacionCliente
    {
        public string datoAValidar { get; set; }
        public OpcionValidacion opcionCorrecta { get; set; }
        public Validacion Validacion { get; set; }
    }
}
