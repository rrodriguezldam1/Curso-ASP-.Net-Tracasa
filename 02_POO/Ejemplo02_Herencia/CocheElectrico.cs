using System;
using System.Collections.Generic;
using System.Text;
using Ejemplo01_Encapsulacion;

namespace Ejemplo02_Herencia
{
    public class CocheElectrico : Coche
    {
        double nivelBateria;

        public double NivelBateria { get => nivelBateria; set => nivelBateria = value; }


        public CocheElectrico(string marca, string modelo, float precio, double nivelBateria) : base(marca, modelo, precio)
        {
            Modelo = modelo;
            Marca = marca;
            Precio = precio;
            NivelBateria = nivelBateria;
        }

        public override string ToString()
        {
            return base.ToString() + " " + NivelBateria + "%";
        }

        public override void Acelerar() { base.Acelerar(); NivelBateria -= 0.1; }
    }
}
