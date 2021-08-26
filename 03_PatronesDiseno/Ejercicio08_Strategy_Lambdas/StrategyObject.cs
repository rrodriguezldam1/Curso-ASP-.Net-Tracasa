using System;
using System.Collections.Generic;
using System.Text;

namespace OtroNameSpace
{
    delegate void VoidFunc();
    class StrategyObject
    {
        protected string nombre;
        string type;

        protected Func<string> GetNombre;
        public string Nombre { get => nombre; set => nombre = value; }
        internal VoidFunc Execute { get => execute; set => execute = value; }
        public Action MostrarNombre { get => mostrarNombre; set => mostrarNombre = value; }

        VoidFunc execute;

        Action mostrarNombre;

        public StrategyObject() : this("")
        {
        }

        public StrategyObject(string mensaje)
        {
            this.GetNombre = () => {
                return mensaje + " " + GetType() + ".Execute()";
            };
            MostrarNombre = () => Console.WriteLine(GetNombre());
        }

        public void RepetirChar(char caracter, int veces)
        {
            for (int i = 0; i < veces; i++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }

        public string Type { get => type; set => type = value; }

        new string GetType()
        {
            return Type;
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
