using PPAI_2023.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.GenerarEntidadesDeSoporte();
            var gestorRegistrarLlamada = new GestorRegistrarLlamada();
            gestorRegistrarLlamada.LlamarRegistrarAccionRequerida();
            //Application.Run(new GestorRegistrarLlamada());
        }
    }
}
