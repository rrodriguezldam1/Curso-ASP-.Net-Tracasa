using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo06_Funcion_Callback
{
    static class Calculadora_A
    {
        public static float SumarA(float a1, float a2) {
            return a1 + a2;
        }

        public static float MultiplicarA(float a1, float a2)
        {
            float res = 0;
            for (int i = 0; i < a2; i++)
            {
                res += a1;
            }
            return res;
        }
    }
}
