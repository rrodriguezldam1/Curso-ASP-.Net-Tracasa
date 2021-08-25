using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio06_Callback_Delegados
{
    // public delegate float FuncionOperacion(float x , float y);
    static class Calculadora
    {
        public static float CalculaArray(float[] lista, Func<float, float, float> operacion)
        {
            float resul = lista[0];
            if (lista.Length <= 1) return resul;
            //for (int i = 1; i < lista.Length; i++)
            //{
            //    resul = operacion.Invoke(resul, lista[i]);
            //}
            return lista.Aggregate(operacion);
        }
    }
}
