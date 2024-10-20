using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Evalucación_Ejercicio2
{
    internal class Class1
    {
        public static int CalcularTotal(int []ventasdiarias) //recibe arreglo tipo entero
        {
            int total = 0;
            foreach (int venta in ventasdiarias) //foreach para recorrer todo el cuerpo del arreglo
            {
                 total += venta;
            }

            return total;
        }
        public static int EncontrarDiaMax(int [] ventasdiarias) //recibe arreglo tipo entero
        { 
            int VentaMax = ventasdiarias[0]; 
            int DiaMax = 0;
            for (int i = 0; i < ventasdiarias.Length; i++) //for para recorrer todo el tamaño del arreglo
            { 
                if (ventasdiarias[i]> VentaMax) //condicional para cambiar el valor del dia maximo
                {
                    VentaMax = ventasdiarias[i];
                    DiaMax = i;
                }

            }
            return DiaMax + 1;

            
        }
    }
}
