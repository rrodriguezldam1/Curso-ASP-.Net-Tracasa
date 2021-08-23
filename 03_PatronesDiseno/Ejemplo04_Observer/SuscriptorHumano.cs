using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo04_Observer
{
    class SuscriptorHumano : ISuscriptorObservador
    {
        string nombre;

        public SuscriptorHumano(string nombre)
        {
            this.nombre = nombre;
        }

        public void ActualizarNoticiaCorazon(string noticia, DateTime fecha)
        {
            Console.WriteLine("¡Nuevas noticias Corazón!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(fecha + " - " + noticia);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ActualizarNotificacionNoticia(string noticia, DateTime fecha)
        {
            Console.Beep();
            Console.WriteLine("¡Nuevas noticias, " + nombre + "!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(fecha + " - " + noticia);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
