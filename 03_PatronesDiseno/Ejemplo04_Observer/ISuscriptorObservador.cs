using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo04_Observer
{
    interface ISuscriptorObservador
    {
        void ActualizarNotificacionNoticia(string noticia, DateTime fecha);
        void ActualizarNoticiaCorazon(string noticia, DateTime fecha);
    }
}
