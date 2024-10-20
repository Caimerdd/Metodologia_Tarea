using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Evalucacíón_Ej2_GD
{
    // Definir el struct Producto
    public struct Producto
    {
        public int Id;
        public string Nombre;
        public decimal Precio;
        public int Cantidad;

        // Constructor para inicializar un producto
        public Producto(int id, string nombre, decimal precio, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
    internal class Inventario
    {
        public void AgregarProducto(Producto[] inventario, ref int contador, string nombre, decimal precio, int cantidad)
        {
            if (contador >= inventario.Length)
            {
                Console.WriteLine("El inventario está lleno, no se puede agregar más productos.");
                return;
            }

            int nuevoId = contador + 1;  // Asignar un ID único
            inventario[contador] = new Producto(nuevoId, nombre, precio, cantidad);
            contador++;
            Console.WriteLine($"Producto {nombre} agregado al inventario.");
        }

        // Función para actualizar la cantidad en stock de un producto
        public void ActualizarStock(Producto[] inventario, int totalProductos, int idProducto, int nuevaCantidad)
        {
            bool productoEncontrado = false;

            for (int i = 0; i < totalProductos; i++)
            {
                if (inventario[i].Id == idProducto)
                {
                    inventario[i].Cantidad = nuevaCantidad;
                    productoEncontrado = true;
                    Console.WriteLine($"Stock del producto {inventario[i].Nombre} actualizado a {nuevaCantidad}.");
                    break;
                }
            }

            if (!productoEncontrado)
            {
                Console.WriteLine("El producto con el ID digitado no existe.");
            }
        }

        // Función para calcular el valor total del inventario
        public decimal CalcularValorTotal(Producto[] inventario, int totalProductos)
        {
            decimal valorTotal = 0;

            for (int i = 0; i < totalProductos; i++)
            {
                valorTotal += inventario[i].Precio * inventario[i].Cantidad;
            }

            return valorTotal;
        }
        public void MostrarInventario(Producto[] inventario, int totalProductos)
        {
            Console.WriteLine("\nProductos en el inventario:");
            for (int i = 0; i < totalProductos; i++)
            {
                Console.WriteLine($"ID: {inventario[i].Id}");
                Console.WriteLine($"Nombre: {inventario[i].Nombre}");
                Console.WriteLine($"Precio: {inventario[i].Precio}");
                Console.WriteLine($"Cantidad: {inventario[i].Cantidad}");
            }
        }
    }
}


