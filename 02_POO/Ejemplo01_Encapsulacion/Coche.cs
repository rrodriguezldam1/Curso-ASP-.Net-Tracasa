using Ejemplo03_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo01_Encapsulacion
{
    public class Coche : INombrable, IShowable
    {
        float velocidad;
        float precio;
        string modelo;
        string marca;

        public float Velocidad { get { return velocidad; } }
        public string Modelo { get { return modelo; } set { this.modelo = value; } }
        public string Marca { get; set; }
        public float Precio { get { return precio; } set { if (value >= 0) this.precio = value; else precio = 0; } }

        public string Nombre { get { return GetNombre(); } set { SetNombre(value); } }

        public virtual void Acelerar() { velocidad++; }

        public Coche(string marca, string modelo, float precio)
        {
            Modelo = modelo;
            Marca = marca;
            Precio = precio;
        }

        public Coche()
        {
            Modelo = "";
            Marca = "";
            Precio = 0;
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj)) return true;
            else {
                Coche objCoche = (Coche)obj;
                if (Modelo == objCoche.Modelo && Marca.Equals(objCoche.Marca) && this.precio == objCoche.precio) return true;
                else return false;
            }
        }

        public override string ToString()
        {
            return Modelo + " " + Marca + " " + precio;
        }

        public string GetNombre()
        {
            return Marca + " - " + Modelo;
        }

        /// <summary>
        /// Establece tanto marca como modelo
        /// </summary>
        /// <param name="unNombre"> Recibe "Marca - Modelo" </param>

        public void SetNombre(string unNombre)
        {
            if (!string.IsNullOrEmpty(unNombre))
            {
                string[] separados = unNombre.Split("-");
                Marca = separados[0].Trim();
                if (separados.Length > 1) Modelo = separados[1].Trim();
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
                        Console.WriteLine("Inserte Marca: ");
                        break;
                    case 1:
                        Console.WriteLine("Inserte Modelo: ");
                        break;
                    case 2:
                        Console.WriteLine("Inserte Precio: ");
                        break;
                }
                linea = Console.ReadLine();
                cadena[i] = linea.Trim();
            }
            Marca = cadena[0];
            Modelo = cadena[1];
            Precio = float.Parse(cadena[2]);
        }
    }
}
