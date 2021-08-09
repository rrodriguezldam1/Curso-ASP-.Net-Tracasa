using System;

namespace Ejemplo01_Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();
            //por defecto es privado, no podemos(ni debemos) modificar directamente.
            //miCoche.velocidad = 10;
            miCoche.Acelerar();
            miCoche.Acelerar();
            miCoche.Modelo = "Kia";
            miCoche.Marca = "BMW";
            miCoche.Precio = 100;
            Console.WriteLine("Velocidad: " + miCoche.Velocidad);
            Console.WriteLine("Modelo: " + miCoche.Modelo);
            Console.WriteLine("Marca: " + miCoche.Marca);

            Usuario user1 = new Usuario("", -20, -1.75f);
            Usuario user2 = new Usuario("Ramón", 22, 1.75f);

            Console.WriteLine();
            Console.WriteLine(user1.Nombre + " " + user1.Edad);
            Console.WriteLine(user2.Nombre + " " + user2.Edad);

            user1.Nombre = "Laura";
            user1.Edad = 21;
            Console.WriteLine(user1.Nombre + " " + user1.Edad);
        }
    }
}
