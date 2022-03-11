using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Vehiculos
{
    internal class DatosAlquileres 
    {
        int nit;
        string placa;
        DateTime fechaAlquiler;
        DateTime fechaDevolucion;
        double kilometrosRecorridos;
        public static List<DatosAlquileres> listaAlquileres = new List<DatosAlquileres>();

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public double KilometrosRecorridos { get => kilometrosRecorridos; set => kilometrosRecorridos = value; }

        public static void GuardarenTxtAlquiler()
        {
            FileStream abrir = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var alquiler in DatosAlquileres.listaAlquileres)
            {
                escribir.WriteLine(alquiler.nit);
                escribir.WriteLine(alquiler.placa);
                escribir.WriteLine(alquiler.fechaAlquiler);
                escribir.WriteLine(alquiler.fechaDevolucion);
                escribir.WriteLine(alquiler.kilometrosRecorridos);
            }
            escribir.Close();
            abrir.Close();
        }

        public static void cargarListaAlquileresdeTxt()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                DatosAlquileres alquiler = new DatosAlquileres();
                alquiler.nit = Convert.ToInt32(leer.ReadLine());
                alquiler.placa = leer.ReadLine();
                alquiler.fechaAlquiler = Convert.ToDateTime(leer.ReadLine());
                alquiler.fechaDevolucion = Convert.ToDateTime(leer.ReadLine());
                alquiler.kilometrosRecorridos = Convert.ToDouble(leer.ReadLine());
                DatosAlquileres.listaAlquileres.Add(alquiler);
            }
            leer.Close();
            stream.Close();
        }
    }
}
