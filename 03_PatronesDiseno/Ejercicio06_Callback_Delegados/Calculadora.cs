using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio06_Callback_Delegados
{
    static class Calculadora
    {
        public static float Suma(float[] lista)
        {
            float resul = lista[0];
            if (lista.Length <= 1) return resul;
            for (int i = 1; i < lista.Length; i++)
            {
                resul += lista[i];
            }
            return resul;
        }

        public static float Resta(float[] lista) {
            float resul = lista[0];
            if (lista.Length <= 1) return resul;
            for (int i = 1; i < lista.Length; i++)
            {
                resul -= lista[i];
            }
            return resul;
        }

        public static float Multiplicacion(float[] lista) {
            float resul = lista[0];
            if (lista.Length <= 1) return resul;
            for (int i = 1; i < lista.Length; i++)
            {
                resul *= lista[i];
            }
            return resul;
        }

        public static float Division(float[] lista) {
            float resul = lista[0];
            if (lista.Length <= 1) return resul;
            for (int i = 1; i < lista.Length; i++)
            {
                resul /= lista[i];
            }
            return resul;
        }

        public static float CalculaArray()
        {
            int cantidad;
            do
            {
                cantidad = Parsear("Cantidad de operandos: ");
            } while (cantidad <= 0);

            float[] array = new float[(int)cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                array[i] = Parsear("Número " + (i + 1) + ": ");
            }
            return Operar(array);
        }

        public static float Operar(float[] array)
        {
            float resul = 0;
            string cadena = "";
            Console.WriteLine("Escoja opción: + - * /");
            while (cadena.Length == 0)
            {
                switch (Console.ReadLine())
                {
                    case "+":
                        resul = Suma(array);
                        cadena = "done";
                        break;
                    case "-":
                        resul = Resta(array);
                        cadena = "done";
                        break;
                    case "*":
                        resul = Multiplicacion(array);
                        cadena = "done";
                        break;
                    case "/":
                        resul = Division(array);
                        cadena = "done";
                        break;
                }
            }
            return resul;
        }

        static int Parsear(string titulo)
        {
            int num;
            bool verdad;
            do
            {
                Console.WriteLine(titulo);
                string cadena = Console.ReadLine();
                verdad = int.TryParse(cadena, out num);
            } while (!verdad);
            return num;
        }
    }
}
