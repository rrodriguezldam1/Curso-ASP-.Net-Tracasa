using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class Muestra
    {
        int entero;
        bool activo;

        public int Entero { get => entero; set => entero = value; }
        public bool Activo { get => activo; set => activo = value; }

        public Muestra(int entero, bool activo)
        {

            Entero = entero;
            Activo = activo;
        }
        public override string ToString()
        {
            return base.ToString() + " - " + Entero + " - " + Activo;
        }
    }
}
