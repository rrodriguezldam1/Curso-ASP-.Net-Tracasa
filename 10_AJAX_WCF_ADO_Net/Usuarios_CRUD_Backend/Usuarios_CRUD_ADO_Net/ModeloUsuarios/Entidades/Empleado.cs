
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloUsuarios
{
    public class Empleado : Usuario
    {
        float salario;
        public Empleado(string nombre, int edad, float altura, float salario) : base(nombre, edad, altura)
        {
            this.salario = salario;
        }

        public Empleado()
        {
            salario = 0;
        }

        public float Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }

        public void SubirSalario()
        {
            salario = salario + 10000;
        }

        public override string ToString()
        {
            return base.ToString() + " Salario: " + salario;
        }

    }
}
