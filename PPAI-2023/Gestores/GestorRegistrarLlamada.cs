using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Gestores
{
    public class GestorRegistrarLlamada
    {
        public GestorRegistrarLlamada()
        {
        }

        public void LlamarRegistrarAccionRequerida()
        {
            var gestorRegistrarRespuesta = new GestorRegistrarRespuesta(new GestorRegistrarAccionRequerida());

            var cliente = Data.Clientes.First();
            var categoriaLlamada = Data.CategoriaLlamadas.First();
            var opcion = categoriaLlamada.Opcion.First();
            var subopcion = opcion.SubopcionLlamada.First();

            var llamada = new Llamada
            {
                Cliente = cliente,
                CambioEstado = new List<CambioEstado>
                {
                    new CambioEstado
                    {
                        FechaHoraInicio = DateTime.Now,
                        Estado = Data.Estados.First(e => e.GetNombre == "Iniciada")
                    }
                }
            };

            Data.Llamadas.Add(llamada);
            Data.CambioEstados.AddRange(llamada.CambioEstado);

            gestorRegistrarRespuesta.OpcionRegistrarseConOperador(llamada, categoriaLlamada, opcion, subopcion);
        }
    }
}
