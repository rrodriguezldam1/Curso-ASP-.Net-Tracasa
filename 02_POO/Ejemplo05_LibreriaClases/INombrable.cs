using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_Interfaces
{
    /* 
    Como un contrato que las clases que la implementen tienen que cumplir
    cualquier clase que implemente la interfaz (NO se dice que herede)
    debe tener programados todos sus métodos y propiedades.

    Las interfaces privadas (como las clases privadas) sólo se pueden usar dentro
    (aplicación, librería DLL..), si son públicos pueden usarse fuera del proyecto.
    */
    public interface INombrable
    {
        string GetNombre();

        void SetNombre(string unNombre);

        string Nombre 
        {
            get;
            set;
        }
    }
}
