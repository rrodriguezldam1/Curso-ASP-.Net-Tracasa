using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo04_Observer
{
    delegate void NoticiaCiencia(string not);
    class PeriodicoObservado
    {
        List<ISuscriptorObservador> listaSuscriptores;
        public NoticiaCiencia NuevaNoticiaCiencia;

        public PeriodicoObservado() {
            listaSuscriptores = new List<ISuscriptorObservador>();
        }

        public void NoticiaCiencia(string laNoticia) {
            if (NuevaNoticiaCiencia != null) {
                NuevaNoticiaCiencia("¡CICIENCIA! " + laNoticia);
            }
        }

        public void NotificarNoticia(string titular, DateTime fecha) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Extra, extra!");          
            Console.WriteLine(fecha.ToString() + " - " + titular);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var suscriptor in listaSuscriptores)
            {
                suscriptor.ActualizarNotificacionNoticia(titular, fecha);
            }
        }

        public void NotificarNoticiaCorazon(string titular, DateTime fecha)
        {
            foreach (var suscriptor in listaSuscriptores)
            {
                suscriptor.ActualizarNoticiaCorazon(titular, fecha);
            }
        }

        public void AddSuscriptor(ISuscriptorObservador observador) {
            listaSuscriptores.Add(observador);
        }

        public void RemoveSuscriptor(ISuscriptorObservador observador)
        {
            listaSuscriptores.Remove(observador);
        }

        ~PeriodicoObservado()

        {
            NotificarNoticia("Vamos a cerrar", DateTime.Now);
            listaSuscriptores.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(DateTime.Now.ToString() + " - " + "Se cierra el periodico por falta de trabajadores");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
