using System;

namespace Ejemplo01_Singleton
{
    class Modulo1
    {
        public static void Main2(string[] args)
        {
            GestorTextos gt = GestorTextos.Instancia;
            gt.Nuevo("AAAAA");
            gt.Nuevo("BBB");
            gt.Nuevo("CCCC");
            gt.Mostrar();
        }
    }
}
