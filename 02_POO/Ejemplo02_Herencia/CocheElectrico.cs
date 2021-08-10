using System;
using System.Collections.Generic;
using System.Text;
using Ejemplo01_Encapsulacion;

namespace Ejemplo02_Herencia
{
    public class CocheElectrico : Coche, ICloneable
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

        public object Clone()
        {
            return new CocheElectrico(Marca, Modelo, Precio, NivelBateria);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine(ToString());
        }

        public override void InsertarDatos()
        {
            base.InsertarDatos();
            Console.WriteLine("Inserte Nivel batería: ");
            string linea;
            linea = Console.ReadLine();
            NivelBateria = double.Parse(linea.Trim());
        }
    }
}
