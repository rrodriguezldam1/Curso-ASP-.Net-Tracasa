using System;
using System.Collections.Generic;

namespace Ejemplo02_Factoria
{
    // https://refactoring.guru/es/design-patterns/factory-method/csharp/example

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a la fabrica!");
            FactoriaProducto fabrica = new FactoriaProducto();
            List<Producto> lista = fabrica.CrearLista(4);
            /* lista.Add(fabrica.Crear(1));
            lista.Add(fabrica.Crear(2));
            lista.Add(fabrica.Crear(3));
            lista.Add(fabrica.Crear(4));*/


            List<Producto> lista2
                = fabrica.CrearLista(new int[] { 2, 7, 3, 1 });
            /* List<Producto> lista2 = new List<Producto>();
            lista2.Add(fabrica.Crear(1));
            lista2.Add(fabrica.Crear(2));*/

            List<Producto> lista3 = fabrica.CrearLista(3, 7);
            /*lista3.Add(fabrica.Crear(3));
            lista3.Add(fabrica.Crear(4));
            lista3.Add(fabrica.Crear(5));
            lista3.Add(fabrica.Crear(6));
            lista3.Add(fabrica.Crear(7));*/

            foreach (var item in lista)
            {
                Console.WriteLine("Objeto de constructor: " + item);
            }
            foreach (var item in lista2)
            {
                Console.WriteLine("Objeto de constructor: " + item);
            }
            foreach (var item in lista3)
            {
                Console.WriteLine("Objeto de constructor: " + item);
            }
        }
    }
}
