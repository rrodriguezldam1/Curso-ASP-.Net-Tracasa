using Ejemplo03_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo01_Encapsulacion
{

    public class Usuario : INombrable, IShowable
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

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string unNombre)
        {
            if (!string.IsNullOrEmpty(unNombre))
            {
                Nombre = unNombre;
            }
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine(ToString());
        }

        public virtual void InsertarDatos()
        {
            string linea;
            string[] cadena = new string[3];

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
                }
                linea = Console.ReadLine();
                cadena[i] = linea.Trim();
            }
            Nombre = cadena[0];
            Edad = int.Parse(cadena[1]);
            Altura = float.Parse(cadena[2]);
        }
    }
}
