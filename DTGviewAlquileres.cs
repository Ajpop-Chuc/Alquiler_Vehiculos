using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Vehiculos
{
    internal class DTGviewAlquileres
    {
        string cliente;
        string placa;
        string marca;
        string modelo;
        string color;
        double precioxKilometro;
        DateTime devolucion;
        double total;

        public string Cliente { get => cliente; set => cliente = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioxKilometro { get => precioxKilometro; set => precioxKilometro = value; }
        public DateTime Devolucion { get => devolucion; set => devolucion = value; }
        public double Total { get => total; set => total = value; }
        }
    }

