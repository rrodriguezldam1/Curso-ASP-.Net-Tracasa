using System;
using Ejemplo01_Encapsulacion;

namespace Ejemplo02_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche("Seat", "Ibiza", 12000);
            Coche tuCoche = new Coche("Seat", "Cordoba", 12000);
            miCoche.Acelerar();
            miCoche.Acelerar();
            Console.WriteLine("To String: " + miCoche.ToString());
            Console.WriteLine("Hash code: " + miCoche.GetHashCode());
            Console.WriteLine("Hash code: " + tuCoche.GetHashCode());
            Console.WriteLine("Get Type: " + tuCoche.GetType().ToString());
            if (miCoche.GetType().Equals(typeof(Coche))) {
                Console.WriteLine("miCoche es un coche!");
            }
            tuCoche.Marca = "Ibiza";
            if (miCoche.Equals(tuCoche))
            {
                Console.WriteLine("miCoche es igual a tuCoche");
            }
            else
            {
                Console.WriteLine("miCoche es diferente a tuCoche");
            }

            Console.WriteLine();

            CocheElectrico cocheE1 = new CocheElectrico("Seat", "Ibiza", 12000, 100);
            Console.WriteLine(cocheE1.ToString());
            Console.WriteLine(cocheE1.Velocidad);
            cocheE1.Acelerar();
            Console.WriteLine(cocheE1.ToString());
            Console.WriteLine(cocheE1.Velocidad);

            Coche cocheTelsa = cocheE1;
            cocheTelsa.Acelerar();
            Console.WriteLine(cocheTelsa.Velocidad + " " + cocheTelsa.ToString());
            cocheTelsa.Acelerar();
            Console.WriteLine(cocheTelsa.Velocidad + " " + cocheTelsa.ToString());
        }
    }
}
