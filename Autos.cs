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
    public partial class Autos : Form
    {
        public Autos()
        {
            InitializeComponent();
        }

        private void Autos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosAutos auto = new DatosAutos();
            auto.Placa = textBoxPlaca.Text;
            auto.Marca = textBoxMarca.Text;
            auto.Modelo = textBoxModelo.Text;
            auto.Color = textBoxColor.Text;
            auto.PrecioxKilometro = Convert.ToDouble(textBoxPrecioxKlm.Text);
            DatosAutos verificar = DatosAutos.listaAutos.Find(x => x.Placa == auto.Placa);
            if (verificar == null)
            {
                DatosAutos.listaAutos.Add(auto);
                DatosAutos.GuardarenTxtAutos();

                textBoxColor.Clear();
                textBoxMarca.Clear();
                textBoxModelo.Clear();
                textBoxPrecioxKlm.Clear();
                textBoxPlaca.Clear();
            }
            else { MessageBox.Show("Error: Auto con placa existente"); }
            
        }

        private void buttonVerVehiculos_Click(object sender, EventArgs e)
        {
            verAutos  Form = new verAutos();
            Form.Show();
        }
    }
}
