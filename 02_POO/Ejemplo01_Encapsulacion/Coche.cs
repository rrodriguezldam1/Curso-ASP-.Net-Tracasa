using Ejemplo03_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo01_Encapsulacion
{
    public class Coche : INombrable
    {
        float velocidad;
        float precio;
        string modelo;
        string marca;

        public float Velocidad { get { return velocidad; } }
        public string Modelo { get { return modelo; } set { this.modelo = value; } }
        public string Marca { get; set; }
        public float Precio { set { if (value >= 0) this.precio = value; else precio = 0; } }

        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void SetNombre(string unNombre)
        {
            throw new NotImplementedException();
        }
    }
}
