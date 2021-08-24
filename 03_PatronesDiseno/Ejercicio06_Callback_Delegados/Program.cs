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
    public delegate float FuncionOperador();
    class Program
    {
        static void Main(string[] args)
        {
            //VistaCalculadoraGenerica(Calculadora.Suma, Calculadora.Resta, Calculadora.Multiplicacion, Calculadora.Division);
            VistaCalc.PedirArray(Calculadora.CalculaArray); 
        }

        //static void VistaCalculadora(FuncionOperador operador)
        //{
        //    float cantidad;

        //    do
        //    {
        //        cantidad = Parsear("Cantidad de operandos: ");
        //    } while (cantidad == 0);
    
        //    float[] array = new float[(int)cantidad];
        //    for (int i = 0; i < cantidad; i++) {
        //        array[i] = Parsear("Número " + (i + 1) + ": ");
        //    }
        //    float resultado = operador(array);
        //    Console.WriteLine("Resultado: " + resultado);
        //}

        //static void VistaCalculadoraGenerica(FuncionOperador funSuma, FuncionOperador funResta, FuncionOperador funMulti, FuncionOperador funDiv)
        //{
        //    float cantidad;
        //    FuncionOperador operador;
        //    operador = funSuma;

        //    do
        //    {
        //        cantidad = Parsear("Cantidad de operandos: ");
        //    } while (cantidad == 0);

        //    float[] array = new float[(int)cantidad];
        //    for (int i = 0; i < cantidad; i++)
        //    {
        //        array[i] = Parsear("Número " + (i + 1) + ": ");
        //    }

        //    switch (Menu())
        //    {
        //        case "SUMA": 
        //            operador = funSuma;
        //            break;
        //        case "RESTA":
        //            operador = funResta;
        //            break;
        //        case "MULTIPLICACION":
        //            operador = funMulti;
        //            break;
        //        case "DIVISION":
        //            operador = funDiv;
        //            break;
        //    }

        //    float resultado = operador(array);
        //    Console.WriteLine("Resultado: " + resultado);
        //}

        //static float Parsear(string titulo) {
        //    float num;
        //    bool verdad;
        //    do
        //    {
        //        Console.WriteLine(titulo);
        //        string cadena = Console.ReadLine();
        //        verdad = float.TryParse(cadena, out num);
        //    } while (!verdad);
        //    return num;
        //}

        //static string Menu() {
        //    string cadena = "";
        //    Console.WriteLine("Escoja opción: + - * /");
        //    while (cadena.Length == 0)
        //    {
        //        switch (Console.ReadLine())
        //        {
        //            case "+":
        //                cadena = "SUMA";
        //                break;
        //            case "-":
        //                cadena = "RESTA";
        //                break;
        //            case "*":
        //                cadena = "MULTIPLICACION";
        //                break;
        //            case "/":
        //                cadena = "DIVISION";
        //                break;
        //        }
        //    }
        //    return cadena;
        //}
    }
}
