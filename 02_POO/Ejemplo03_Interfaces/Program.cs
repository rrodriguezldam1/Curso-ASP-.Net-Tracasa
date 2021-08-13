using Ejemplo01_Encapsulacion;
using Ejemplo02_Herencia;
using Ejercicio02_Herencia;
using System;
using System.Collections.Generic;

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

            Program.EjemploLista();
        }

        static void EjemploLista() {
            List<string> textos = new List<string>();
            // Por defecto, se crean 10 o 20 elementos, pero esto nos da igual
            // porque lo hace de manera interna
            textos.Add("1");
            textos.Add("2");
            textos.Add("3");
            textos.Add("4");
            textos.Add("5");
            textos.Add("6"); // internamente va usando el array
            for (int i = 7; i < 30; i++) {
                textos.Add(i.ToString());
            }
            // Llegará un punto que internamente tenga que ampliar dinámicamente
            textos.RemoveAt(2);
            textos.Remove("1");
            for (int i = 0; i < textos.Count; i++)
            {
                Console.WriteLine("Lista: " + textos[i]);
            }

            List<Coche> coches = new List<Coche>();
            coches.Add(new Coche("Toyota", "Cupra", 50000));
            coches.Add(new Coche("Tesla", "F21", 40000));
            IList<Usuario> listaUsu = new List<Usuario>();
            listaUsu.Add(new Usuario("Usuario listaUsu 1", 0, 0));
            listaUsu.Add(new Usuario("Usuario listaUsu 2", 0, 0));

            IList<Usuario> arrayUsu = new Usuario[10];
            arrayUsu[0] = new Usuario("Usuario arrayUsu 2", 0, 0);
            arrayUsu[1] = new Usuario("Usuario arrayUsu 2", 0, 0);
            arrayUsu[4] = new Usuario("Usuario arrayUsu 2", 0, 0);

            MostrarColeccion(listaUsu);
            MostrarColeccion(arrayUsu);
        }

        static void MostrarColeccion(ICollection<Usuario> coleccion)
        {
            Console.WriteLine("Colección usuarios " + coleccion.GetType());
            foreach (Usuario usu in coleccion)
            {
                if (usu != null) //continue;
                    usu.MostrarDatos();
            }
        }
    }
}
