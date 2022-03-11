using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Vehiculos
{
    internal class DatosCliente
    {
        int nit;
        string nombre;
        string direccion;
        public static List<DatosCliente> listaClientes = new List<DatosCliente>();

        public int Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public static void GuardarenTxtClientes()
        {
            FileStream abrir = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var cliente in DatosCliente.listaClientes)
            {
                escribir.WriteLine(cliente.nit);
                escribir.WriteLine(cliente.nombre);
                escribir.WriteLine(cliente.direccion);
            }
            escribir.Close();
            abrir.Close();
        }
        public static void cargarListaClientesdeTxt()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                DatosCliente cliente = new DatosCliente();
                cliente.nit = Convert.ToInt32(leer.ReadLine());
                cliente.nombre = leer.ReadLine();
                cliente.direccion = leer.ReadLine();
                DatosCliente.listaClientes.Add(cliente);
            }
            leer.Close();
            stream.Close();
        }
    }
}
