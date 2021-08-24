using System;

// Ejercicio: Crear dos sistemas (clases independientes
// que no se conocen entre sí):
// La primera tendrá 4 funciones para sumer,rest,mult, div
// todo con float. Estas podrán realizar la operación sobre 
// un array:
// {9, 7, 5, 3} suma -> 24    resta -> -6   mul -> 945
// {42, 3, 2} div -> (42 / 3) / 2 -> 7
// {3} -> cualquier operador devuelve 3.
// No puede estar vacio el array
// La segunda clase, le pide al usuario cuantos operandos habrá
// y los operandos uno por uno, la operación y mostrará el resultado.
// si alguien quiere, en vez de eso, que resuelva: 3+22++11 ó 7*3*11*2

namespace Ejercicio06_Callback_Delegados
{
    public delegate float[] FuncionOperador(float[] arr);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VistaCalc.PedirArray(Calculadora.CalculaArray));
        }
    }
}
