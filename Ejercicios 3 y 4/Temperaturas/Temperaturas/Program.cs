using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas;

//Crea un programa que use una lista genérica para almacenar temperaturas en grados
//Celsius.Implementa funciones para convertirlas a Fahrenheit y Kelvin, y mostrar las
//temperaturas convertidas, las cuales se almacenan en nuevas listas respectivamente.
//- El programa se repetirá las veces que el usuario lo decida.
//- Utilizar funciones con parámetros.
//- Agregar una función que permita eliminar de la lista que contiene las temperaturas
//convertidas. La que el usuario elija

// Definición del struct Temperatura
public struct Temperatura
{
    public double Celsius { get; set; }

    // Constructor para inicializar la temperatura en Celsius
    public Temperatura(double celsius)
    {
        Celsius = celsius;
    }
}

// Clase principal del programa
class Program
{
    static void Main(string[] args)
    {
        // Listas para almacenar temperaturas en Celsius, Fahrenheit y Kelvin
        List<Temperatura> temperaturasCelsius = new List<Temperatura>();
        List<double> temperaturasFahrenheit = new List<double>();
        List<double> temperaturasKelvin = new List<double>();

        bool continuar = true;
        while (continuar)
        {
            // Solicitar al usuario que introduzca una temperatura en Celsius
            Console.WriteLine("Introduce una temperatura en grados Celsius:");
            double tempCelsius = Convert.ToDouble(Console.ReadLine());
            temperaturasCelsius.Add(new Temperatura(tempCelsius));

            // Convertir la temperatura a Fahrenheit y Kelvin
            double tempFahrenheit = ConversorTemp.ConvertirAFahrenheit(tempCelsius);
            double tempKelvin = ConversorTemp.ConvertirAKelvin(tempCelsius);
                
            // Almacenar las temperaturas convertidas en sus respectivas listas
            temperaturasFahrenheit.Add(tempFahrenheit);
            temperaturasKelvin.Add(tempKelvin);

            // Mostrar las temperaturas convertidas al usuario
            Console.WriteLine($"Temperatura en Fahrenheit: {tempFahrenheit}");
            Console.WriteLine($"Temperatura en Kelvin: {tempKelvin}");

            // Preguntar al usuario si desea introducir otra temperatura
            Console.WriteLine("¿Quieres introducir otra temperatura? (s/n)");
            continuar = Console.ReadLine().ToLower() == "s";
        }

        // Preguntar al usuario si desea eliminar alguna temperatura convertida
        Console.WriteLine("¿Deseas eliminar alguna temperatura convertida? (s/n)");
        if (Console.ReadLine().ToLower() == "s")
        {
            // Pedir al usuario que elija la lista (Fahrenheit o Kelvin)
            Console.WriteLine("Elige la lista: 1. Fahrenheit 2. Kelvin");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Pedir al usuario que introduzca la temperatura a eliminar
            Console.WriteLine("Introduce la temperatura que deseas eliminar:");
            double tempAEliminar = Convert.ToDouble(Console.ReadLine());

            // Llamar al método de eliminación según la opción elegida
            if (opcion == 1)
            {
                ConversorTemp.EliminarTemperatura(temperaturasFahrenheit, tempAEliminar);
            }
            else if (opcion == 2)
            {
                ConversorTemp.EliminarTemperatura(temperaturasKelvin, tempAEliminar);
            }
            Console.ReadKey();
        }
    }
}