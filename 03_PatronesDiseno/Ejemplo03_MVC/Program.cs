using System;

namespace Ejemplo03_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            IModeloEjemplo model1 = new ModeloEjemDiccionario();
            //IModeloEjemplo model2 = new ModeloEjemploLista();
            model1.Crear(1, "Uno");
            model1.Crear(2, "Dos");
            model1.Crear(3, "Tres");

            VistaEjemplo ve = new VistaEjemplo(model1);
            ve.AltaEjemplo();
            ve.MostrarEjemplos();
            /*ve.MostrarUno("Tres");
            ve.MostrarUno("Estres");*/
        }
    }
}
