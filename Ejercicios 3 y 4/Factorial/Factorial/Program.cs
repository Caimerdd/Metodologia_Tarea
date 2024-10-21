using Factorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crea un programa que use un arreglo estático para almacenar números y una función
//que calcule el factorial de cada número, el cual es enviado a un segundo arreglo.
//Muestra los resultados, es decir ambos arreglos
//- El número es leído en la función principal Main y es enviado como parámetro a la
//función que calcula el factorial. Recuerda que el factorial no se calcula para números
//negativos. Por lo tanto, al arreglo original sólo debes guardar los números positivos
//o cero.
//- El programa se repetirá mientras el usuario lo desea

class Program
{
    static void Main(string[] args)
    {
        const int TAMANO = 10; // Tamaño del arreglo estático
        int[] numeros = new int[TAMANO];
        long[] factoriales = new long[TAMANO];

        int index = 0;
        bool continuar = true;

        while (continuar && index < TAMANO)
        {
            Console.WriteLine("Introduce un número positivo o cero:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                numeros[index] = num;
                factoriales[index] = CalcularFact.CalcularFactorial(num);
                index++;
            }
            else
            {
                Console.WriteLine("El número debe ser positivo o cero.");
            }

            if (index < TAMANO)
            {
                Console.WriteLine("¿Quieres introducir otro número? (s/n)");
                continuar = Console.ReadLine().ToLower() == "s";
            }
            else
            {
                Console.WriteLine("El arreglo está lleno.");
            }
        }

        // Mostrar los resultados
        Console.WriteLine("\nNúmeros ingresados y sus factoriales:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine($"Número: {numeros[i]}, Factorial: {factoriales[i]}");
        }
        Console.ReadKey();
    }
}