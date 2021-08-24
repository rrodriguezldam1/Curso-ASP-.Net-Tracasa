using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio06_Callback_Delegados
{
    class VistaCalc
    {
        public static void PedirArray(FuncionOperador operador)
        {
            Console.WriteLine(operador.ToString());
        }
    }
}
