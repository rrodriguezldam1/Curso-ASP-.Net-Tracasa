using Ejemplo01_Encapsulacion;
using Ejemplo02_Herencia;
using Ejemplo03_Interfaces;
using Ejercicio02_Herencia;
using System;

namespace Ejercicio03_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Usuario user1 = new Usuario("Ramon", 22, 1.75f);
            Empleado user2 = new Empleado("Ramon", 22, 1.75f, 12000);
            INombrable users1 = user1;
            INombrable users2 = user2;
            user1.Nombre = "Sergio";
            user2.Nombre = "Laura";
            Console.WriteLine(user1.Nombre);
            Console.WriteLine(user2.Nombre);

            Console.WriteLine();

            INombrable[] array = new INombrable[2];
            array[0] = new Empleado("Ramon", 22, 1.75f, 12000);
            array[1] = new CocheElectrico("Peugeot", "407", 22000, 100);
            Console.WriteLine(array[0].Nombre + " conduce un " + array[1].Nombre);

            Console.WriteLine();

            Usuario user3 = new Usuario("Ramon", 22, 1.75f);
            user3.MostrarDatos();
            user3.InsertarDatos();
            user3.MostrarDatos();

            Console.WriteLine();

            Empleado emp3 = new Empleado("Ramon", 22, 1.75f, 24500);
            emp3.MostrarDatos();
            emp3.InsertarDatos();
            emp3.MostrarDatos();

            Console.WriteLine();

            Coche car3 = new Coche("Peugeot", "407", 22000f);
            car3.MostrarDatos();
            car3.InsertarDatos();
            car3.MostrarDatos();

            Console.WriteLine();

            CocheElectrico carE3 = new CocheElectrico("Peugeot", "407", 22000f, 100.0);
            carE3.MostrarDatos();
            carE3.InsertarDatos();
            carE3.MostrarDatos();
        }
    }
}
