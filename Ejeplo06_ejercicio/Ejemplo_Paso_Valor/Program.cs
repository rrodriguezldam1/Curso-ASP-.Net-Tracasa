using System;

namespace Ejemplo_Paso_Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 10;
            string cadena = "Hola soy Ramon";

            //Console.WriteLine("Entero fuera y antes: " + variable);
            //RecibimosUnValor(variable);
            //Console.WriteLine("Entero fuera y despúes: " + variable);

            //Console.WriteLine("Entero fuera y antes: " + variable);
            //RecibimosUnaReferencia(ref variable);
            //Console.WriteLine("Entero fuera y despúes: " + variable);

            Console.WriteLine("Cadena fuera y antes: " + cadena);
            RecibimosUnaReferenciaString(ref cadena);
            Console.WriteLine("Entero fuera y despúes: " + cadena);
        }

        static void RecibimosUnValor(int entero) 
        {
            Console.WriteLine("Entero dentro y antes: " + entero);
            entero = entero * 2 + 1;
            Console.WriteLine("Entero dentro y despúes: " + entero);
        }
        
        static void RecibimosUnaReferencia(ref int entero) 
        {
            Console.WriteLine("Entero dentro y antes: " + entero);
            entero = entero * 2 + 1;
            Console.WriteLine("Entero dentro y despúes: " + entero);
        }
        
        static void RecibimosUnaReferenciaString(ref string cadena) 
        {
            Console.WriteLine("Cadena dentro y antes: " + cadena);
            cadena = cadena.ToUpper();
            Console.WriteLine("Entero dentro y despúes: " + cadena);
        }
    }
}
