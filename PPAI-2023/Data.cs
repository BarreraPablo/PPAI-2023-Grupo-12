using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023
{
    /// <summary>
    /// La intencion de esta clase es almacenar en memoria listas de objetos.
    /// Basicamente sirve como una mini base de datos
    /// </summary>
    public static class Data
    {
        public static List<Accion> Acciones { get; set; } = new List<Accion>();
        public static List<CambioEstado> CambioEstados { get; set; } = new List<CambioEstado>();
        public static List<CategoriaLlamada> CategoriaLlamadas { get; set; } = new List<CategoriaLlamada>();
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public static List<Estado> Estados { get; set; } = new List<Estado>();
        public static List<InformacionCliente> InformacionClientes { get; set; } = new List<InformacionCliente>();
        public static List<Llamada> Llamadas { get; set; } = new List<Llamada>();
        public static List<OpcionLlamada> OpcionLlamadas { get; set; } = new List<OpcionLlamada>();
        public static List<OpcionValidacion> OpcionValidaciones { get; set; } = new List<OpcionValidacion>();
        public static List<SubOpcionLlamada> SubOpcionLlamadas { get; set; } = new List<SubOpcionLlamada>();
        public static List<Validacion> Validacion { get; set; } = new List<Validacion>();


        public static void GenerarEntidadesDeSoporte()
        {
            var subopciones = new List<SubOpcionLlamada>
            {
                new SubOpcionLlamada
                {
                    NroOrder = 1,
                    Nombre = "Sub opcion 1"
                },
                new SubOpcionLlamada
                {
                    NroOrder = 2,
                    Nombre = "Sub opcion 2"
                }
            };

            var opcionesLlamada = new List<OpcionLlamada>
            {
                new OpcionLlamada
                {
                    NroOrden = 1,
                    Nombre = "Opcion llamada 1",
                    SubopcionLlamada = new List<SubOpcionLlamada>
                    {
                        subopciones[0], subopciones[1]
                    }
                },
                new OpcionLlamada
                {
                    NroOrden = 1,
                    Nombre = "Opcion llamada 2"
                },
                new OpcionLlamada
                {
                    NroOrden = 1,
                    Nombre = "Opcion llamada 3"
                },
                new OpcionLlamada
                {
                    NroOrden = 1,
                    Nombre = "Opcion llamada 4"
                }
            };
            OpcionLlamadas.AddRange(opcionesLlamada);

            var categoriaLlamadas = new List<CategoriaLlamada>
            {
                new CategoriaLlamada
                {
                    NroOrden = 1,
                    Nombre = "Categoria 1",
                    Opcion = new List<OpcionLlamada> { opcionesLlamada[0], opcionesLlamada[1] }
                },
                new CategoriaLlamada
                {
                    NroOrden = 1,
                    Nombre = "Categoria 2",
                    Opcion = new List<OpcionLlamada> { opcionesLlamada[2], opcionesLlamada[3] }
                }
            };
            CategoriaLlamadas.AddRange(categoriaLlamadas);

            var clientes = new List<Cliente>
            {
                new Cliente
                {
                    Dni = 11222333,
                    NroCelular = 35122333112,
                    NombreCompleto = "Juan Fernandez"
                },
                new Cliente
                {
                    Dni = 22222333,
                    NroCelular = 35522333442,
                    NombreCompleto = "Pedro Alfonso"
                }
            };
            Clientes.AddRange(clientes);

            var estados = new List<Estado>
            {
                new Estado
                {
                    Nombre = "Iniciada",
                },
                new Estado
                {
                    Nombre = "En Curso"
                },
                new Estado
                {
                    Nombre = "Finalizada"
                }
            };

        }

    }
}
