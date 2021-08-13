using System;

namespace Ejemplo01_Singleton
{
    class Modulo1
    {
        static void Main(string[] args)
        {
            GestorTextos gt = new GestorTextos();
            gt.Nuevo("AAAAA");
            gt.Nuevo("BBB");
            gt.Nuevo("CCCC");
            gt.Mostrar();
        }
    }
}
