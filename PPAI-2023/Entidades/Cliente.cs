using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Cliente
    {
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }


        private string nombreCompleto;
        public string NombreCompleto
        {
            set { nombreCompleto = value; }
        }
        public string GetNombre() {
            return nombreCompleto;
        }


        private long nroCelular;
        public long NroCelular
        {
            get { return nroCelular; }
            set { nroCelular = value; }
        }


    }
}
