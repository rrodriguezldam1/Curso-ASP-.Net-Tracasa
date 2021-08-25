using System;

namespace Wikipedia.Patterns.Strategy
{
    // MainApp Test para aplicacion
    class MainApp
    {
        static void Main()
        {
            Context context;
            //StrategyBase s = new StrategyBase("Hola");
            // No se puede

            // Tres contextos con diferentes estrategias
            context = new Context(new ConcreteStrategyA("Hola"));
            context.Execute();

            context = new Context(new ConcreteStrategyB());
            context.Execute();

            context = new Context(new ConcreteStrategyC("Adios"));
            context.Execute();

        }
    }
    // Una clase abstracta, lo principal es que no puede ser instanciada,
    // como las interfaces, puede tener algunos métodos implementados
    // y otros sin implementar (declarando sólo su interfaz). Estos
    // métodos son abstractos.
    abstract class StrategyBase
    {
        protected string nombre;

        public StrategyBase(string mensaje) {
            nombre = mensaje + " " + GetType().Name + ".Execute";
        }

        protected void RepetirChar(char caracter, int veces) {
            for (int i = 0; i < veces; i++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
        public abstract void Execute();

        public virtual void MostrarNombre() {
            Console.WriteLine(nombre);
        }
    }

    interface IStrategy
    {
        void Execute();
    }

    // Implementa el algoritmo usando el patron estrategia
    class ConcreteStrategyA : StrategyBase
    {
        public ConcreteStrategyA(string mensaje) : base(mensaje) {         
        }

        public override void Execute()
        {
            RepetirChar('-', 30);
            MostrarNombre();
        }
        public override void MostrarNombre()
        {
            RepetirChar('_', 30);
            base.MostrarNombre();
            RepetirChar('_', 30);
        }
    }

    class ConcreteStrategyB : StrategyBase
    {
        public ConcreteStrategyB() : base("Llamar a")
        {
        }

        public override void Execute()
        {
            RepetirChar('\n', 3);
            MostrarNombre();
        }
    }

    class ConcreteStrategyC : StrategyBase
    {
        public ConcreteStrategyC(string nombre) : base("")
        {
            this.nombre = nombre;
        }

        public override void Execute()
        {
            MostrarNombre();
            RepetirChar('*', 30);
        }
    }

    // Contiene un objeto ConcreteStrategy y mantiene una referencia a un objeto Strategy
    class Context
    {
        StrategyBase strategy;

        // Constructor
        public Context(StrategyBase strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }
}
