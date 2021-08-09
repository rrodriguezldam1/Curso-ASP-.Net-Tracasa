using System;

namespace Ejemplo12_TratamientoCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //string texto = "   En un lugar de La Mancha de cuyo nombre me quiero acordar, pero no me acuerdo.   ";
            //string[] palabras = texto.Trim().Split(" ");

            //Console.WriteLine("Original: " + texto);
            //Console.WriteLine("Sin espacios: " + texto.Trim());
            //Console.WriteLine("MAYUSCULAS: " + texto.ToUpper());
            //Console.WriteLine("minusculas: " + texto.ToLower());
            //Console.WriteLine("Un cacho: " + texto.Substring(20, 20));
            //Console.WriteLine("Un cacho hasta el final: " + texto.Substring(20));
            //Console.WriteLine("La Mancha?: " + texto.IndexOf("La Mancha"));
            //Console.WriteLine("Pamplona?: " + texto.IndexOf("Pamplona"));
            //Console.WriteLine("Un cacho: " + texto.Substring(20));
            //for (int i = 0; i < palabras.Length; i++) Console.WriteLine(palabras[i]);
            //Console.WriteLine("Cantidad de palabras: " + palabras.Length);
            //Console.WriteLine("Reemplazar: " + texto.Replace("La Mancha", "Pamplona"));

            string linea = "";
            string palabras = "";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce una palabras: ");
                linea = Console.ReadLine().Trim().Replace(" ", "");
                if (i != 2) palabras += linea + ",";
                else palabras += linea;
            }
            Console.WriteLine("Esas palabras son: " + palabras);
        }
    }
}
