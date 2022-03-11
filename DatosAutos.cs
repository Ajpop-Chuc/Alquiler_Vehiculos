using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Vehiculos
{
    internal class DatosAutos
    {
        string placa;
        string marca;
        string modelo;
        string color;
        double precioxKilometro;

        public static List<DatosAutos> listaAutos = new List<DatosAutos>();

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioxKilometro { get => precioxKilometro; set => precioxKilometro = value; }

        public static void GuardarenTxtAutos()
        {
            FileStream abrir = new FileStream("Autos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var auto in DatosAutos.listaAutos)
            {
                escribir.WriteLine(auto.Placa);
                escribir.WriteLine(auto.Marca);
                escribir.WriteLine(auto.Modelo);
                escribir.WriteLine(auto.Color);
                escribir.WriteLine(auto.PrecioxKilometro);
            }
            escribir.Close();
            abrir.Close();
        }
        public static void cargarListaAutosdeTxt()
        {
            FileStream stream = new FileStream("Autos.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                DatosAutos auto = new DatosAutos();
                auto.placa = leer.ReadLine();
                auto.marca = leer.ReadLine();
                auto.modelo = leer.ReadLine();
                auto.color = leer.ReadLine();
                auto.precioxKilometro = Convert.ToDouble(leer.ReadLine());
                DatosAutos.listaAutos.Add(auto);
            }
            leer.Close();
            stream.Close();
        }
    }
}
