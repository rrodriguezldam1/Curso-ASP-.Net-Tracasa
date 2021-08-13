using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo02_Factoria
{
    // Imaginemos que esta clase viene de una DLL externa y no podemos modificarla.
    class Producto
    {
        int id;
        string nombre;

        public Producto()
        {
            id = 10;
            nombre = "Por defecto";

        }
        public Producto(int e)
        {
            id = e;
            nombre = "Por defecto";
        }
        public Producto(int e, string s)
        {
            id = e;
            nombre = s;
        }
        public override string ToString()
        {
            return base.ToString() + " - " + id + " - " + nombre;
        }
    }
}
