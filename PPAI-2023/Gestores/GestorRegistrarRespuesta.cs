using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Gestores
{
    public class GestorRegistrarRespuesta
    {
        private Llamada llamada;
        private CategoriaLlamada categoria;
        private OpcionLlamada opcion;
        private SubOpcionLlamada subOpcionLlamada;
        private Estado estadoEnCurso;

        private PantRegistrarRespuesta pantRegistrarRespuesta = new PantRegistrarRespuesta();

        public void OpcionRegistrarseConOperador(Llamada llamada, CategoriaLlamada categoria, OpcionLlamada opcion, SubOpcionLlamada subOpcionLlamada)
        {
            this.llamada = llamada;
            this.categoria = categoria;
            this.opcion = opcion;
            this.subOpcionLlamada = subOpcionLlamada;

            SetEstadoEnCurso();
            ObtenerDatosLlamada();
        }

        private void SetEstadoEnCurso()
        {
            estadoEnCurso = BuscarEstadoParaAsignar();
            var fechaHoraActual = GetFechaYHoraActual();
            llamada.SetEstadoEnCurso(fechaHoraActual, estadoEnCurso);
        }

        private Estado BuscarEstadoParaAsignar()
        {
            foreach (var estado in Data.Estados)
            {
                if(estado.EsEnCurso())
                {
                    return estado;
                }
            }

            return null;
        }

        private DateTime GetFechaYHoraActual()
        {
            return DateTime.Now;
        }

        private void ObtenerDatosLlamada()
        {
            var nombreCliente = llamada.GetNombreClienteDeLlamada();
            var subOpcionNombre = 
        }
    }
}
