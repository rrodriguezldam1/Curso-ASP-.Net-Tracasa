using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo04_Observer
{
    class SuscriptorMaquina : ISuscriptorObservador
    {
        int codigo;

        public SuscriptorMaquina(int codigo)
        {
            this.codigo = codigo;
        }

        public void ActualizarNoticiaCorazon(string noticia, DateTime fecha)
        {
            Console.WriteLine("Pasando del tema...");
        }

        public void ActualizarNotificacionNoticia(string noticia, DateTime fecha)
        {
            Console.Beep();
            Console.WriteLine("¡Nuevas noticias!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(fecha + " - " + " Soy " + codigo + " -> "+ noticia);
            Console.ForegroundColor = ConsoleColor.White;
            System.IO.File.AppendAllText("NoticiaMaquina.txt", "\n" + noticia + "\n");
        }
    }
}
