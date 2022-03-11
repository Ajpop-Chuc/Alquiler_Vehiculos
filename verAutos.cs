using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_Vehiculos
{
    public partial class verAutos : Form
    {
        public verAutos()
        {
            InitializeComponent();
        }

        private void verAutos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = DatosAutos.listaAutos;
            dataGridView1.Refresh();

        }
    }
}
