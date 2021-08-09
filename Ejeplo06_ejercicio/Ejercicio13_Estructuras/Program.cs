using System;

namespace Ejercicio13_Estructuras
{
    public struct Usuario
    {
        private string nombre;
        private int edad;
        private float altura;

        public Usuario(string nombre, int edad, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
        }

        public void MostrarUsuario()
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
            Console.Write("Altura: ");
            Console.WriteLine(altura);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Usuario user1 = new Usuario("Leonardo",20,1.70f);
            Usuario user2 = new Usuario("Raphael", 23, 1.75f);
            Usuario[] users = new Usuario[4];
            users[0] = user1;
            users[1] = user2;
            string nombre;
            int edad;
            float altura;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Usuario " + (i + 1) + ": ");
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura = float.Parse(Console.ReadLine());
                users[i + 2] = new Usuario(nombre,edad,altura);
                Console.WriteLine("\n");
            }
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Usuario " + (i + 1) + ": ");
                users[i].MostrarUsuario();
            }
            Console.ReadKey();
        }
    }
}
