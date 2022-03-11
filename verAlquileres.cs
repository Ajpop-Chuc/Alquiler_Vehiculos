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
    public partial class verAlquileres : Form
    {

        List<DTGviewAlquileres> listamostraralquileres = new List<DTGviewAlquileres>();
        public verAlquileres()
        {
            InitializeComponent();
        }

        private void verAlquileres_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            cargadDataListaMostrar();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = listamostraralquileres;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargadDataListaMostrar()
        {
            DatosAlquileres Datoalquiler = new DatosAlquileres();
            foreach (var alquiler in DatosAlquileres.listaAlquileres)
            {

                DTGviewAlquileres mostraralquiler = new DTGviewAlquileres();
                DatosCliente cliente = DatosCliente.listaClientes.Find(x => x.Nit == alquiler.Nit);
                DatosAutos auto = DatosAutos.listaAutos.Find(x => x.Placa == alquiler.Placa);
                mostraralquiler.Cliente = cliente.Nombre;
                mostraralquiler.Placa = auto.Placa;
                mostraralquiler.Marca = auto.Marca;
                mostraralquiler.Modelo = auto.Modelo;
                mostraralquiler.Color = auto.Color;
                mostraralquiler.PrecioxKilometro = auto.PrecioxKilometro;
                mostraralquiler.Devolucion = alquiler.FechaDevolucion;
                mostraralquiler.Total = auto.PrecioxKilometro * alquiler.KilometrosRecorridos;
                listamostraralquileres.Add(mostraralquiler);
            }
        }
    }              
}
