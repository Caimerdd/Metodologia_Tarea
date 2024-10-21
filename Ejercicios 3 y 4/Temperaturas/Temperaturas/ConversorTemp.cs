using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    internal class ConversorTemp
    {
        // Método para convertir de Celsius a Fahrenheit
        public static double ConvertirAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Método para convertir de Celsius a Kelvin
        public static double ConvertirAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        // Método para eliminar una temperatura de una lista
        public static void EliminarTemperatura(List<double> lista, double temperatura)
        {
            if (lista.Contains(temperatura))
            {
                lista.Remove(temperatura);
                Console.WriteLine("La temperatura ha sido eliminada correctamente.");
            }
            else
            {
                Console.WriteLine($"La temperatura {temperatura} no se encontró en la lista.");
            }
        }
    }
}
