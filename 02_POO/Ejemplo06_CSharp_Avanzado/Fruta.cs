using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo06_CSharp_Avanzado
{
    public class Fruta
    {
        string nombre;
        float pesoMedio;        

        public string Nombre { get => nombre; set => nombre = value; }
        public float Peso { get => pesoMedio; set => pesoMedio = value; }

        public Fruta(string nombre, float peso)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Peso = peso;
        }

        public override string ToString()
        {
            return "Fruta " + nombre + " peso medio = " + pesoMedio + " gr.";
        }
    }
}
