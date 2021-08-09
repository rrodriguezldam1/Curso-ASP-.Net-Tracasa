using System;

namespace Ejemplo06_ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if (num1 > num2)
            {
                Console.Write(num1);
            }
            else
            {
                Console.Write(num2);
            }
            Console.ReadKey();
        }
    }
}
