using System;
using System.Collections.Generic;
using System.Text;
using Ejemplo01_Encapsulacion;
using Ejemplo03_Interfaces;

namespace Ejercicio02_Herencia
{
    public class Empleado : Usuario
    {
        int salario;

        public Empleado(string nombre, int edad, float altura, int salario) : base(nombre, edad, altura)
        {
            Salario = salario;
        }

        public Empleado()
        {
            Salario = 0;
        }

        public int Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
            return base.ToString().Replace("Usuario", "Empleado") + " Salario: " + Salario + " $";
        }

        public override void InsertarDatos() {
            string linea;
            string[] cadena = new string[4];

            for (int i = 0; i < cadena.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Inserte Nombre: ");
                        break;
                    case 1:
                        Console.WriteLine("Inserte Edad: ");
                        break;
                    case 2:
                        Console.WriteLine("Inserte altura: ");
                        break;
                    case 3:
                        Console.WriteLine("Inserte salario: ");
                        break;
                }
                linea = Console.ReadLine();
                cadena[i] = linea.Trim();
            }
            Nombre = cadena[0];
            Edad = int.Parse(cadena[1]);
            Altura = float.Parse(cadena[2]);
            Salario = int.Parse(cadena[3]);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine(ToString());
        }
    }
}
