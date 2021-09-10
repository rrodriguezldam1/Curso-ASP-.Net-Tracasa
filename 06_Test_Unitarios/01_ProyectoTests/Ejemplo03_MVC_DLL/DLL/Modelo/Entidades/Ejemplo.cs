using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Modelo.Entidades
{
    public class Ejemplo
    {
        int entero;
        string str;
        //TODO: NO DEVOLVER ENTERO, PREGUNTAR CON MÉTODO
        public Ejemplo(int e, string s)
        {
            entero = e;
            Str = s;
        }

        public string Str { get => str; set => str = value; }

        public bool EsEntero(int ent)
        {
            return this.entero == ent;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + entero + " - " + Str;
        }
    }
}
