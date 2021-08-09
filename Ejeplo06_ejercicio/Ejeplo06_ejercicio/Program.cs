using System;

namespace Ejeplo06_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int cantidad, siguiente = 0, x, y, primerCuadrante = 0, segundoCuadrante = 0, tercerCuadrante = 0, cuartoCuadrante = 0;
            Console.WriteLine("Cantidad de puntos a procesar");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            Console.WriteLine("(x,y)");
            for ( ; siguiente < cantidad; siguiente++) {
                Console.WriteLine("valor de la x ");
                linea = Console.ReadLine();
                x = int.Parse(linea);
                Console.WriteLine("valor de la y ");
                linea = Console.ReadLine();
                y = int.Parse(linea);
                if (x > 0)
                {
                    if (y > 0) primerCuadrante++;
                    if (y < 0) segundoCuadrante++;
                }
                else 
                {
                    if (y > 0) cuartoCuadrante++;
                    if (y < 0) tercerCuadrante++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de puntos por cuadrante:");
            Console.WriteLine("Primer cuadrante: " + primerCuadrante);
            Console.WriteLine("Segundo cuadrante: " + segundoCuadrante);
            Console.WriteLine("Tercer cuadrante: " + tercerCuadrante);
            Console.WriteLine("Cuarto cuadrante: " + cuartoCuadrante);
        }
    }
}
