using System;

namespace Ejemplo08_if_Operadores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = int.MinValue;
            int minimo = int.MaxValue;
            string linea;
            int n, num;
            Console.Write("Ingrese numero de valores:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 0; i < n; i++) {
                Console.Write("Ingrese un valor: ");
                linea = Console.ReadLine();
                linea = linea == "" ? null : linea;
                linea = linea ?? "5";
                num = int.Parse(linea);
                if (mayor < num) mayor = num;
                if (minimo > num) minimo = num;
            }
            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El mínimo número es: " + minimo);
            Console.ReadKey();
        }
    }
}
