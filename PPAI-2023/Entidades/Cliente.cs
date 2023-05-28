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

        private List<InformacionCliente> informacionCliente;

        private List<String> datosEnLlamada;

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

        public void EjecutarValidacion()
        {
            foreach (var datoAValidar in datosEnLlamada)
            {
                EsInformacionCorrecta(datoAValidar);
            }
        }

        public void EsInformacionCorrecta(string datoAValidar)
        {
            OpcionValidacion opcionValidacion = new OpcionValidacion();
            opcionValidacion.EsCorrecta(datoAValidar);            
        }
    }
}
