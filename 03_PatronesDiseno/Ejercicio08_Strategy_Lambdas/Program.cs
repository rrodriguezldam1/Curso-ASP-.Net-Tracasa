using OtroNameSpace;
using System;

namespace Wikipedia.Patterns.Strategy
{
    // MainApp Test para aplicacion
    class MainApp
    {
        static void Main()
        {
            StrategyBase sB;

            sB = ConcretesStrategies.AddConcreteStrategyA(new StrategyBase((nombre) => nombre.Trim()));
            sB.Execute();

            sB = ConcretesStrategies.AddConcreteStrategyA(new StrategyBase((nombre) => nombre.Trim()));
            sB.Execute();

            sB = ConcretesStrategies.AddConcreteStrategyA(new StrategyBase((nombre) => nombre.Trim()));
            sB.Execute();
        }
    }
    public static class ConcretesStrategies
    {
        public static StrategyBase AddConcreteStrategyA(StrategyBase strObj)
        {
            // Dinamicamente le damos la funcionalidad que antes hacíamos por herencia
            // Tanto public override void Execute()
            // como public override void MostrarNombre()
            return strObj;
        }
    } 
}