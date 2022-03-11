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
    public partial class Alquileres : Form
    {

        public Alquileres()
        {
            InitializeComponent();
        }

        private void Alquileres_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonIngresarAlquiler_Click(object sender, EventArgs e)
        {
            DatosAlquileres alqulier = new DatosAlquileres();
            alqulier.Nit = Convert.ToInt32(textBoxNit.Text);
            alqulier.Placa = textBoxPlaca.Text;
            alqulier.FechaAlquiler = dateTimePickerAlquiler.Value.Date;
            alqulier.FechaDevolucion = dTPFDevolucion.Value.Date;
            alqulier.KilometrosRecorridos = Convert.ToDouble(textBoxKlmRecorridos.Text);
            DatosAlquileres.listaAlquileres.Add(alqulier);
            DatosAlquileres.GuardarenTxtAlquiler();
            textBoxKlmRecorridos.Clear();
            textBoxNit.Clear();
            textBoxPlaca.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
