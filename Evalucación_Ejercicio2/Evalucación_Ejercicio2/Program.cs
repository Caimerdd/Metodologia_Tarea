using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Implementa un programa que use un arreglo estático para almacenar las ventas diarias
    de un negocio. Crea funciones para ingresar las ventas, calcular el total vendido y
    encontrar el día con la venta más alta.
    - Utilizar funciones con parámetros.
    - Implementar ciclos.
 */
namespace Evalucación_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DIAS = 7; //constante de los dias de la semana
            int[] Ventasdiarias = new int[DIAS];
            for (int i = 0; i < DIAS; i++) //ciclo para almacenar las ventas diarias
            {
                Console.WriteLine("Ingrese la venta del día {0}", i + 1);
                Ventasdiarias[i] = int.Parse(Console.ReadLine());
            }
            int totalvendido = Class1.CalcularTotal(Ventasdiarias);//se llama la funcion de la clase externa
            int DiaMax = Class1.EncontrarDiaMax(Ventasdiarias); //se llama la funcion de la clase externa

            Console.WriteLine($"El total de ventas es de {totalvendido}"); 
            Console.WriteLine($"El dia que mas se vendio fue el día {DiaMax}");  
            Console.ReadKey();
            
        }
    }
}
