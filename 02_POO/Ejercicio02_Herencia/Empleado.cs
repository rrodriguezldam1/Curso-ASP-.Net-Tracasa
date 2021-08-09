using System;
using System.Collections.Generic;
using System.Text;
using Ejemplo01_Encapsulacion;

namespace Ejercicio02_Herencia
{
    class Empleado : Usuario
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
    }
}
