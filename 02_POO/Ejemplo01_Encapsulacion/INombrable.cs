using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_Interfaces
{
    interface INombrable
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
