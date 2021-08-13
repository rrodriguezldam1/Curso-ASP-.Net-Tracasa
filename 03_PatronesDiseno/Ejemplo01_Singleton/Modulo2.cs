using System;

namespace Ejemplo01_Singleton
{
    class Modulo2
    {
        static void Main2(string[] args)
        {
            GestorTextos gt = new GestorTextos();
            gt.Nuevo("DDDD");
            gt.Nuevo("EEEE");
            gt.Nuevo("FFFF");
            gt.Mostrar();
        }
    }
}
