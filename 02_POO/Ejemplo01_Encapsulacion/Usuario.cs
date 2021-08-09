using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo01_Encapsulacion
{

    public class Usuario
    {
        string nombre;
        int edad;
        float altura;

        public string Nombre { get { return nombre; } set { nombre = value == "" || value == null ? "SIN NOMBRE" : value; } }
        public int Edad { get { return edad; } set { this.edad = value <= 0 ? 1 : value; } }
        public float Altura { get { return altura; } set { this.altura = value <= 0.1f ? 0.1f : value; } }

        public Usuario(string nombre, int edad, float altura)
        {
            Nombre = nombre;
            Edad = edad;
            Altura = altura;
        }

        public Usuario()
        {
            Nombre = "UserXXXX";
            Edad = 0;
            Altura = 0;
        }

        public override string ToString()
        {
            return "Usuario: " + Nombre + " Edad: " + Edad + " Altura: " + Altura + " m";
        }
    }
}
