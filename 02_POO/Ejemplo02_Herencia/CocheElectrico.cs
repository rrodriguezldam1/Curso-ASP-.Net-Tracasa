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
            string linea;
            string[] cadena = new string[4];

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
                    case 3:
                        Console.WriteLine("Inserte Nivel de batería: ");
                        break;
                }
                linea = Console.ReadLine();
                cadena[i] = linea.Trim();
            }
            Marca = cadena[0];
            Modelo = cadena[1];
            Precio = float.Parse(cadena[2]);
            NivelBateria = double.Parse(cadena[3]);
        }
    }
}
