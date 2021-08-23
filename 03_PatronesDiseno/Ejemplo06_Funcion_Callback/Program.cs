using System;

namespace Ejemplo06_Funcion_Callback
{
    // Creamos un nuevo tipo de dato, que indica que es una función
    // ni clase, ni interfaz...). Donde lo que importa son los tipos
    // de datos que recibe y que devuelve.
    // Es decir, declaramos un delegado.
    delegate float FuncionOperador(float op1, float op2);
    // Ahora podemos crear variables de tipo float función(float, float)
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Invocamos con sumaA");
            //// Al pasar como parámetro la función SumarA, no lleva
            //// paréntesis, porque NO se llama ahora, sino después
            //VistaCalculadora(Calculadora_A.SumarA);
            //Console.WriteLine("Invocamos con multiplicarA");
            //VistaCalculadora(Calculadora_A.MultiplicarA);

            //Console.WriteLine("\nInvocamos con sumaB");
            //// Al pasar como parámetro la función SumarA, no lleva
            //// paréntesis, porque NO se llama ahora, sino después
            //VistaCalculadora(Calculadora_B.SumarB);
            //Console.WriteLine("Invocamos con multiplicarB");
            //VistaCalculadora(Calculadora_B.MultiplicarB);

            VistaOperadora(Calculadora_B.SumarB, Calculadora_B.MultiplicarB);
        }

        // Esta función necesita de una función callback
        // para saber como tiene que calcular.
        static void VistaCalculadora(FuncionOperador operador) {
            Console.WriteLine("Operando 1:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Operando 2:");
            float y = float.Parse(Console.ReadLine());
            float resultado = operador(x, y);
            Console.WriteLine("Resultado: " + resultado);
        }

        static void VistaOperadora(FuncionOperador funSuma, FuncionOperador funMultiplicacion)
        {
            FuncionOperador operador;
            bool hacer = true;
            string[] lista = new string[3];
            Console.WriteLine("Introduce operación: ");
            string cadena = Console.ReadLine().Trim();
            lista = cadena.Split("+");
            operador = funSuma;
            if (lista.Length < 2) {
                lista = cadena.Split("*");
                operador = funMultiplicacion;
            }
            if (lista.Length < 2)
            {
                Console.WriteLine("No te entiendo, humano");
                hacer = false;
                // return;
            }
            if (hacer)
            {
                float resultado = operador(float.Parse(lista[0]), float.Parse(lista[1]));
                Console.WriteLine("Resultado: " + resultado);
            }
        }
    }
}
