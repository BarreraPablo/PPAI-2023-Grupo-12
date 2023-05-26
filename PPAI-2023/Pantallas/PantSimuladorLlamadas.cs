using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023.Pantallas
{
    public partial class PantSimuladorLlamadas : Form
    {
        public PantSimuladorLlamadas()
        {
            InitializeComponent();
            Data.GenerarEntidadesDeSoporte();
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            var categoriasDisponibles = Data.CategoriaLlamadas;
            cbCategoria.DisplayMember= "nombre";
            cbCategoria.DataSource= categoriasDisponibles;
        }

        private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
