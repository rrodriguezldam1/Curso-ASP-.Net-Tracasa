using OtroNameSpace;
using System;

namespace Wikipedia.Patterns.Strategy
{
    // MainApp Test para aplicacion
    class MainApp
    {
        static void Main()
        {
            StrategyObject sB1 = ConcretesStrategies.NewConcreteStrategyA("Hola");
            sB1.Execute();

            StrategyObject sB2 = ConcretesStrategies.NewConcreteStrategyB();
            sB2.Execute();

            StrategyObject sB3 = ConcretesStrategies.NewConcreteStrategyC("Adios");
            sB3.Execute();
        }
    }
    static class ConcretesStrategies
    {
        public static StrategyObject NewConcreteStrategyA(string mensaje)
        {
            StrategyObject strObj = new StrategyObject(mensaje);
            strObj.Type = "ConcreteStrategyA";
            // Dinamicamente le damos la funcionalidad que antes hacíamos por herencia
            // Tanto public override void Execute()
            // como public override void MostrarNombre()
            strObj.Execute = () =>
            {
                strObj.RepetirChar('-', 30);
                strObj.MostrarNombre();
            };
            Action anteriorMostrarNombre = strObj.MostrarNombre;
            strObj.MostrarNombre = () =>
            {
                strObj.RepetirChar('_', 30);
                anteriorMostrarNombre();
                strObj.RepetirChar('_', 30);
            };
            return strObj;
        }

        public static StrategyObject NewConcreteStrategyB()
        {
            StrategyObject strObj = new StrategyObject("Llamar a");
            strObj.Type = "ConcreteStrategyB";
            strObj.Execute = () =>
            {
                strObj.RepetirChar('\n', 3);
                strObj.MostrarNombre();
            };
            return strObj;
        }
        public static StrategyObject NewConcreteStrategyC(string mensaje)
        {
            StrategyObject strObj = new StrategyObject(mensaje);
            // strObj.GetNombre() = () => mensaje;
            strObj.Nombre = mensaje;
            // strObj.Type = "ConcreteStrategyC";
            strObj.Execute = () =>
            {  
                strObj.MostrarNombre();
            };
            strObj.MostrarNombre = () =>
            {
                Console.WriteLine(strObj.Nombre);  // strObj.Nombre);
                strObj.RepetirChar('*', 30);
            };
            return strObj;
        }

    } 
}