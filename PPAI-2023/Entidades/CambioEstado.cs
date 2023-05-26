using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;

        public DateTime FechaHoraInicio
        {
            set { fechaHoraInicio = value; }
        }

        private Estado estado;

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public DateTime GetFechaHoraInicio => fechaHoraInicio;

    }
}
