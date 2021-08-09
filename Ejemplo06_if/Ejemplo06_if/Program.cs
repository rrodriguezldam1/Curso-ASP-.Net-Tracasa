using System;

namespace Ejemplo06_if
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string linea;
            {
                Console.Write("Ingrese el sueldo:");
                linea = Console.ReadLine();
            }
            sueldo = float.Parse(linea);
            if (sueldo > 3000) Console.Write("Esta persona debe abonar impuestos");
            Console.ReadKey();
        }
    }
}
