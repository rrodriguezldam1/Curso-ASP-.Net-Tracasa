using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    public class Ejemplo
    {
        int entero;
        string str;
        public Ejemplo(int e, string s)
        {
            entero = e;
            Str = s;
        }

        public string Str { get => str; set => str = value; }
        public int Entero { get => entero; }

        public override string ToString()
        {
            return base.ToString() + " - " + entero + " - " + Str;
        }
    }
}
