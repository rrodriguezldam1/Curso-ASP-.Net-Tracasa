using System;

namespace Ejemplo04_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Programa();
            Console.WriteLine("<<<<<: Función Terminada");
            // Aquí recolectamos todas las instancias en memoria sin referencias.
            System.GC.Collect();
            System.Threading.Thread.Sleep(1500);
        }
        static void Programa()
        {
            Console.WriteLine("Patrón observer: Periódico");
            PeriodicoObservado alDia = new PeriodicoObservado();
            // 1 - Un suscriptor humano
            SuscriptorHumano juan = new SuscriptorHumano("Juan");
            alDia.AddSuscriptor(juan);
            // 2 - Ocurre una noticia
            alDia.NotificarNoticia("Un meteorito roza la Luna", DateTime.Now);
            // 3 - Otro suscriptor humano
            SuscriptorHumano mema = new SuscriptorHumano("Mema");
            alDia.AddSuscriptor(mema);
            // 4 - Otro suscriptor máquina, lleva un código int en vez de nombre
            SuscriptorMaquina maquine = new SuscriptorMaquina(12);
            alDia.AddSuscriptor(maquine);
            // 5 - Ocurre otra noticia
            alDia.NotificarNoticia("Ahora el meteorito va a rozar a la Tierra", DateTime.Now);
            // Noticia corazon:
            alDia.NotificarNoticiaCorazon("Una actriz besó a un fan", DateTime.Now);
            // 6 - El otro humano se desuscribe porque dice mucha mentira
            alDia.RemoveSuscriptor(mema);
            // 7 - Ocurre la última noticia
            alDia.NotificarNoticia("La raza humana ha sido extinguida", DateTime.Now);
            // 8 - El periódico cierra
            Console.WriteLine(">>>>>: Terminando Función");

            // Para que el suscritor de ciencia se pueda suscribir,
            // simplemente se asigna la función al campo delegado:
            alDia.NuevaNoticiaCiencia = NationalGeo;
            // Cuando realmente ocurre la noticia de ciencia:
            alDia.NoticiaCiencia("El meteorito existía y era de criptonita");

        } // Variables locales, por eso aqí se destruye "alDia" y se queda la instancia sin referencia.

        // Este suscriptor solo es una función
        static void NationalGeo(string noticia) {
            Console.WriteLine(">>>>>> A saber: " + noticia);
        }
    }
}
