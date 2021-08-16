using System;

namespace Ejemplo03_MVC
{
    class Program
    {
        IVistaEjemplo ve;
        IModeloEjemplo model1;

        Program() {
            model1 = new ModeloEjemDiccionario();
            ControladorEjemplo con = new ControladorEjemplo(model1);
            ve = new VistaEjemplo(con);
        }
        void ProbarDatos() {
            model1.Crear(1, "Uno");
            model1.Crear(2, "Dos");
            model1.Crear(3, "Tres");

            ve.AltaEjemplo();
            ve.MostrarEjemplos();
            /*ve.MostrarUno("Tres");
            ve.MostrarUno("Estres");*/
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.ProbarDatos();
            program.ve.Menu();
        }
    }
}
