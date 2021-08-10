using Ejemplo01_Encapsulacion;
using Ejemplo02_Herencia;
using Ejercicio02_Herencia;
using System;


namespace Ejemplo03_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Por lo general no es aconsejable crear un array de objetos
            // OJO: Esto es solo a nivel educativo
            // Lo normal es declarar un array de clases, interfaces o  clases abstractas
            object[] popurri = new object[3];
            popurri[0] = new Coche("Fiat", "Punto", 9000);
            popurri[1] = new CocheElectrico("Fiat", "Punto", 9000, 100.0);
            popurri[2] = new Usuario("Ramon", 22, 1.75f);

            foreach (object obj in popurri) 
            {
                Console.WriteLine(obj.ToString());
            }

            ((Coche)popurri[0]).SetNombre("FIAT - PUNTO 4.5");
            Coche fiatPunto = (Coche) popurri[0];
            Console.WriteLine(fiatPunto.GetNombre());
            // El polimorfismo se puede usar con interfaces
            INombrable fiatNombrable = /*(INombrable)*/ fiatPunto;
            INombrable fiatENombrable = (CocheElectrico) popurri[1];
            fiatNombrable.Nombre = "Fiat - Punto Version 1034";
            fiatENombrable.Nombre = "Fiat - Electric";
            Console.WriteLine(fiatNombrable.Nombre);
            Console.WriteLine(fiatENombrable.Nombre);

            
        }
    }
}
