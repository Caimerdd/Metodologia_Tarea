using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalucacíón_Ej2_GD
{
    internal class Programx
    {

        static void Main(string[] args)
        {
            const int MAX_PRODUCTOS = 100;  // Máximo número de productos en el inventario
            Producto[] inventario = new Producto[MAX_PRODUCTOS];  // Arreglo para almacenar los productos
            int totalProductos = 0;  // Contador de productos en el inventario

            // Crear una instancia de la clase GestionInventario
            Inventario gestion = new Inventario();

            // Ciclo principal del programa
            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Actualizar stock");
                Console.WriteLine("3. Mostrar inventario");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Agregar producto
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese el precio del producto: ");
                        decimal precio = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Ingrese la cantidad en stock del producto: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        // Agregar el producto al inventario
                        gestion.AgregarProducto(inventario, ref totalProductos, nombre, precio, cantidad);
                        break;

                    case "2":
                        // Actualizar stock
                        bool idValido = false;
                        int idProducto = 0;

                        // Bucle para asegurarse de que se ingrese un ID válido
                        while (!idValido)
                        {
                            Console.Write("Ingrese el ID del producto a actualizar: ");
                            idProducto = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < totalProductos; i++)
                            {
                                if (inventario[i].Id == idProducto)
                                {
                                    idValido = true;
                                    break;
                                }
                            }

                            if (!idValido)
                            {
                                Console.WriteLine("El producto con el ID digitado no existe. Por favor, ingrese un ID válido.");
                            }
                        }

                        Console.Write("Ingrese la nueva cantidad en stock: ");
                        int nuevaCantidad = Convert.ToInt32(Console.ReadLine());

                        // Actualizar el stock del producto
                        gestion.ActualizarStock(inventario, totalProductos, idProducto, nuevaCantidad);
                        break;

                    case "3":
                        // Mostrar inventario
                        gestion.MostrarInventario(inventario, totalProductos);
                        break;

                    case "4":
                        // Salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
