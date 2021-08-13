using System;

namespace Ejemplo01_Singleton
{
    class Modulo2
    {
        public static void Main(string[] args)
        {
            GestorTextos.Instancia.Nuevo("DDDD");
            GestorTextos.Instancia.Nuevo("EEEE");
            GestorTextos.Instancia.Nuevo("FFFF");
            GestorTextos.Instancia.Mostrar();
            Modulo1.Main2(null);
        }
    }
}
