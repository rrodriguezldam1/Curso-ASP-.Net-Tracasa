using System;
using System.Collections.Generic;

namespace Ejemplo02_Factoria
{
    // https://refactoring.guru/es/design-patterns/factory-method/csharp/example

    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1(2);
            Class1 c3 = new Class1(3, "Tres");
            Console.WriteLine("Vamos a la fabrica!");
            ClaseFactoria fabrica = new ClaseFactoria();
            Class1 c4 = fabrica.CrearObjeto();

            List<Class1> lista = new List<Class1>();
            lista.Add(c1);
            lista.Add(c2);
            lista.Add(c3);
            lista.Add(c4);
            foreach (var item in lista)
            {
                Console.WriteLine("Objeto de constructor: " + item);
            }
        }
    }
}
