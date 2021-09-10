using Ejemplo03_MVC.DLL.Vista;
using Ejemplo03_MVC.DLL.Modelo;
using Ejemplo03_MVC.DLL.Modelo.Interfaces;
using System;
using Ejemplo03_MVC.DLL;

namespace Ejemplo03_MVC.Aplicacion
{
    class Program
    {
        IModeloEjemplo model1;
        VistaEjemplo ve;

        Program()
        {
            this.model1 = new ModeloEjemploLista();
            ControladorEjemplo controlador = new ControladorEjemplo(model1);
            // engachamos el MVC
            this.ve = new VistaEjemplo(controlador);
        }
        void ProbarDatos()
        {
            model1.Crear(1, "Uno");
            model1.Crear(2, "Dos");
            model1.Crear(3, "Tres");

            ve.AltaEjemplo();
            ve.MostrarEjemplos();
            /* ve.MostrarUno("Tres"); ve.MostrarUno("Estres");*/
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ProbarDatos();
            program.ve.Menu();
        }
    }
}
