using Ejemplo06_CSharp_Avanzado.MetodosExt;
using System;

namespace Ejemplo06_CSharp_Avanzado
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruta esLaPera = new Fruta("La pera repera", 150.01f);
            Fruta esLaManzana = new Fruta("Manzanares", 150.01f);
            Fruta esLaBanana = new Fruta("Menuda banana", 150.01f);
            Console.WriteLine(esLaPera.ToString());
            Console.WriteLine(esLaPera.FormatearNombre());
            Console.WriteLine(FormatearNombreN(esLaPera));
            Console.WriteLine(esLaPera.FormatearNombre("Texto Formato"));
            int[] otroArray = new int[] {3, 2, 1};
            Console.WriteLine(otroArray.ToUpperString());
            string[] otroArrayStr = new string[] {"tres", "dos", "uno"};
            Console.WriteLine(otroArrayStr.ToUpperString());
            Fruta[] otroArrayFruta = new Fruta[] { esLaPera, esLaManzana, esLaBanana};
            Console.WriteLine(otroArrayFruta.ToUpperString());

            // Ejercicio: Método de extension de array, que sea array.ToStringFiltrado(string cadena);
            // Que sólo muestre los ToString() que contengan cadena, sin tener en cuenta mayus o minus.

            Fruta esLaMelones = new Fruta("Melón Sandia Sapo", 150.01f);
            Fruta esLaLima = new Fruta("Uñas Limadas", 150.01f);
            Fruta[] otroArrayFrutaDos = new Fruta[] { esLaPera, esLaManzana, esLaBanana, esLaMelones, esLaLima};
            Console.WriteLine(otroArrayFrutaDos.ToStringFiltrado("Man"));

            string[] otroArrayNums = new string[] {"Uno", "Dos", "Tres"};
            Console.WriteLine(otroArrayNums.ToStringFiltrado("s"));
        }
        
        public static string FormatearNombreN(Fruta lafruta)
        {
            // Esto NO es un Método de extensión
            return "FRUTA: " + lafruta.Nombre.ToUpper();

        }
    }
}
