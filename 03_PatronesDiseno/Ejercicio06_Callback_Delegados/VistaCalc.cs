using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio06_Callback_Delegados
{
    // public delegate float FuncionArray(float[] arr, FuncionOperacion operacion);
    class VistaCalc
    {
        public static float PedirArray(Func<float[], Func<float, float, float>, float> funOperar)
        {
            float cantidad;

            do
            {
                cantidad = Parsear("Cantidad de operandos: ");
            } while (cantidad == 0);

            float[] array = new float[(int)cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                array[i] = Parsear("Número " + (i + 1) + ": ");
            }

            float resul = 0;
            string cadena = "";
            while (cadena.Length == 0)
            {
                Console.WriteLine("Escoja opción: + - * /");
                switch (Console.ReadLine())
                {
                    case "+":
                        resul = funOperar.Invoke(array, (float a1, float a2) => a1 + a2);
                        cadena = "doneSuma";
                        break;
                    case "-":
                        resul = funOperar.Invoke(array, (float a1, float a2) => a1 - a2);
                        cadena = "doneResta";
                        break;
                    case "*":
                        resul = funOperar.Invoke(array, (float a1, float a2) => a1 * a2);
                        cadena = "doneMultiplicacion";
                        break;
                    case "/":
                        resul = funOperar.Invoke(array, (float a1, float a2) => a1 / a2);
                        cadena = "doneDivision";
                        break;
                }
            }
            return resul;
        }

        static float Parsear(string titulo)
        {
            float num;
            bool verdad;
            do
            {
                Console.WriteLine(titulo);
                string cadena = Console.ReadLine();
                verdad = float.TryParse(cadena, out num);
            } while (!verdad);
            return num;
        }
    }
}
