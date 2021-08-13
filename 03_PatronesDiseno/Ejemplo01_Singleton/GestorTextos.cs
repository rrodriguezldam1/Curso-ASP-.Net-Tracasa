using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo01_Singleton
{
    class GestorTextos
    {
        private List<string> textos;

        public GestorTextos()
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
