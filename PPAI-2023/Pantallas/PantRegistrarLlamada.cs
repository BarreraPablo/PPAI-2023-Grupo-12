using PPAI_2023.Gestores;
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
    public partial class PantRegistrarLlamada : Form
    {
        public PantRegistrarLlamada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gestorRegistarLlamada = new GestorRegistrarLlamada();
            gestorRegistarLlamada.LlamarRegistrarAccionRequerida();
        }
    }
}
