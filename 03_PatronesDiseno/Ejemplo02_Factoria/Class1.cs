using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo02_Factoria
{
    class Class1
    {
        int entero;
        string str;

        public Class1()
        {
            entero = 10;
            str = "Por defecto";

        }
        public Class1(int e)
        {
            entero = e;
            str = "Por defecto";
        }
        public Class1(int e, string s)
        {
            entero = e;
            str = s;
        }
        public override string ToString()
        {
            return base.ToString() + " - " + entero + " - " + str;
        }
    }
}
