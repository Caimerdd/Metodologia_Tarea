using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class CalcularFact
    {
        // Método para calcular el factorial de un número
        public static long CalcularFactorial(int numero)
        {
            if (numero < 0) return -1; // El factorial no se define para números negativos
            if (numero == 0 || numero == 1) return 1; // El factorial de 0 y 1 es 1

            long factorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
