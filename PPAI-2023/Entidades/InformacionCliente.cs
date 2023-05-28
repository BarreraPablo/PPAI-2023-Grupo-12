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
        private Validacion validacion { get; set; }

        public bool esValidacion(Validacion datoAValidar)
        {
            if (validacion == datoAValidar) return true;
            else return false;
        }

        public bool EsInformacionCorrecta(string datoAValidar)
        {
            OpcionValidacion opcionValidacion = new OpcionValidacion();
            return opcionValidacion.EsCorrecta(datoAValidar);
        }
    }
}
