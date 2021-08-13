using System;

namespace Ejemplo03_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeloEjemplo model1 = new ModeloEjemplo();
            model1.Nuevo(new Ejemplo(1, "Uno"));
            model1.Nuevo(new Ejemplo(2, "Dos"));
            model1.Nuevo(new Ejemplo(3, "Tres"));

            VistaEjemplo ve = new VistaEjemplo(model1);
            ve.MostrarEjemplos();
            ve.MostrarUno("Tres");
            ve.MostrarUno("Estres");
        }
    }
}
