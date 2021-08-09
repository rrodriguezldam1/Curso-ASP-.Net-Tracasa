using System;

namespace Ejercicio13_Estructuras
{
    class Program
    {
        public struct Usuario
        {
            public Usuario(string nombre, int edad, double altura)
            {
                Nombre = nombre;
                Edad = edad;
                Altura = altura;
            }

            public string Nombre { get; }
            public int Edad { get; }
            public double Altura { get; }

        }

        static void Main(string[] args)
        {
            Usuario user1 = new Usuario("Ramon", 22, 175);
            Usuario user2 = new Usuario("Imanol", 20, 185);

            Usuario[] lista = new Usuario[4];

            lista[0] = user1;
            lista[1] = user2;

            string linea, nombre;
            int edad, altura;

            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Nombre: ");
                linea = Console.ReadLine().Trim();
                nombre = linea;
                Console.WriteLine("Edad: ");
                linea = Console.ReadLine().Trim();
                edad = int.Parse(linea);
                Console.WriteLine("Altura: ");
                linea = Console.ReadLine().Trim();
                altura = int.Parse(linea);

                lista[i + 2] = new Usuario(nombre, edad, altura);
                Console.WriteLine();
            }

             void MostrarUsuarios()
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.WriteLine("Nombre: " + lista[i].Nombre + "\tEdad: " + lista[i].Edad + "\tAltura: " + lista[i].Altura + " cm");
                }
            }

            MostrarUsuarios();
        }
        
    }
}
