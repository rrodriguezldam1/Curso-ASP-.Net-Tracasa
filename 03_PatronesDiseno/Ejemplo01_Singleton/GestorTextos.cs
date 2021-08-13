using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo01_Singleton
{
    class GestorTextos
    {
        static GestorTextos instancia;

        private List<string> textos;


        public static GestorTextos Instancia {
            get {
                if (instancia == null) instancia = new GestorTextos();
                return instancia;
            }
        }
        private GestorTextos()
        {
            textos = new List<string>();
        }

        public void Nuevo(string t)
        {
            textos.Add(t);
        }
        public void Mostrar()
        {
            foreach (string s in textos)
            {
                Console.WriteLine(s);
            }
        }
    }
}
