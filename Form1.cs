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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatosAutos.cargarListaAutosdeTxt();
            DatosCliente.cargarListaClientesdeTxt();
            DatosAlquileres.cargarListaAlquileresdeTxt();
            CenterToScreen();
        }

        private void buttonIngresarAuto_Click(object sender, EventArgs e)
        {
            Autos form = new Autos();
            form.Show();
        }

        private void buttonIngresarCliente_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void buttonIngresarAlquiler_Click(object sender, EventArgs e)
        {
            Alquileres form = new Alquileres();
            form.Show();
        }

        private void buttonVerAlquileres_Click(object sender, EventArgs e)
        {
            verAlquileres form = new verAlquileres();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double klmmaximo= DatosAlquileres.listaAlquileres.Max(x=>x.KilometrosRecorridos);
            MessageBox.Show("El mayor kilometraje registrado ha sido de: " + klmmaximo.ToString());
        }
    }
}
