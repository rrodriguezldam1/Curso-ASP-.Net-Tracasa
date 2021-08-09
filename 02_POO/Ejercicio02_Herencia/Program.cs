using Ejemplo01_Encapsulacion;
using System;

namespace Ejercicio02_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] usuarios = new Usuario[4];

            Usuario user1 = new Usuario("Ramón", 22, 1.75f);
            Usuario user2 = new Usuario("Imanol", 20, 1.85f);

            Empleado emp1 = new Empleado("Laura", 20, 1.72f, 2200);
            Empleado emp2 = new Empleado("Sergio", 20, 1.80f, 1800);

            usuarios[0] = user1;
            usuarios[1] = user2;
            usuarios[2] = emp1;
            usuarios[3] = emp2; 

            for (int i = 0; i < usuarios.Length; i++) {
                if (usuarios[i].GetType().Equals(typeof(Empleado))) ((Empleado) usuarios[i]).Salario += 350;
                Console.WriteLine(usuarios[i].ToString());
            }  
        }
    }
}
