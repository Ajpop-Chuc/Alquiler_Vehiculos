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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.Nit = Convert.ToInt32(textBoxNit.Text);
            cliente.Nombre = textBoxNombre.Text;
            cliente.Direccion = textBoxDireccion.Text;
            DatosCliente.listaClientes.Add(cliente);
            DatosCliente.GuardarenTxtClientes();
            textBoxDireccion.Clear();
            textBoxNit.Clear();
            textBoxNombre.Clear();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verClientes form = new verClientes();
            form.Show();
        }
    }
}
