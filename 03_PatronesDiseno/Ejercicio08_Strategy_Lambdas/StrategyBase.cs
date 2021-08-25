using System;
using System.Collections.Generic;
using System.Text;

namespace OtroNameSpace
{
    public class StrategyBase
    {
        string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public StrategyBase(Func<string, string> nombre)
        {
            Nombre = nombre + " " + GetType().Name + ".Execute";
        }

        protected void RepetirChar(char caracter, int veces)
        {
            for (int i = 0; i < veces; i++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
        public virtual void Execute() { }

        public virtual void MostrarNombre()
        {
            Console.WriteLine(Nombre);
        }
    }

    // Contexto ya no tiene sentido
    //class Context
    //{
    //    StrategyBase strategy;

    //    // Constructor
    //    public Context(StrategyBase strategy)
    //    {
    //        this.strategy = strategy;
    //    }

    //    public void Execute()
    //    {
    //        strategy.Execute();
    //    }
    //}
}
