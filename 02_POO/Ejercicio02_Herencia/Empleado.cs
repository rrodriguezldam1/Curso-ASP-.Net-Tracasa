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
            base.InsertarDatos();
            string linea;
            Console.WriteLine("Inserte salario: ");
            linea = Console.ReadLine();
            Salario = int.Parse(linea.Trim());
        }

        public override void MostrarDatos()
        {
            Console.WriteLine(ToString());
        }
    }
}
