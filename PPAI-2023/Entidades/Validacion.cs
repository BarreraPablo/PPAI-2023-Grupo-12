using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Validacion
    {
        private string AudioMensajeValidacion;
        public string Nombre { get; set; }
        public int NroOrder { get; set; }
        public List<OpcionValidacion> opcionesValidacion { get; set; }

        public string GetAudioMensajeValidacion => AudioMensajeValidacion;
    }
}
