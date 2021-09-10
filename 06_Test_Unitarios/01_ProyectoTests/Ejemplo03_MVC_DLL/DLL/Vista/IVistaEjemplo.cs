using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Vista
{
    public interface IVistaEjemplo
    {
        // ¿Es necesario?    Pues en principio NO
        /*ControladorEjemplo Controlador
        {
            get; set;
        }*/
        public void Menu();
        public void AltaEjemplo();
        public void MostrarEjemplos();
    }
}
