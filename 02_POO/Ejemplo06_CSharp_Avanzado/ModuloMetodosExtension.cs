using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo06_CSharp_Avanzado.MetodosExt
{
    // En C# podemos añadir métodos a una clase desde otras clases:
    public static class ModuloMetodosExtension
    {
        // Mediante una función estática, con esta estructura:
        public static string FormatearNombre(this Fruta lafruta)
        {
            // Esto es un Método de extensión
            string nombreFormateado = "FRUTA: " + lafruta.Nombre.ToUpper();
            return nombreFormateado;
        }

        public static string FormatearNombre(this Fruta lafruta, string formato)
        {
            // Esto es un Método de extensión
            return formato + " " + lafruta.Nombre.ToUpper();
        }
        public static string ToUpperString(this object cualquierObjeto)
        {
            return cualquierObjeto.ToString().ToUpper();
        }

        public static string ToUpperString(this Array cualquierarray)
        {
            string result = "Array: " + cualquierarray.ToString().ToLower();
            foreach (var item in cualquierarray)
            {
                result += "\n - " + item.ToUpperString();
            }
            return result;
        }

        public static string ToStringFiltrado(this Array cualquierarray, string cadena)
        {
            string result = "Array: " + cualquierarray.ToString().ToLower();
            foreach (var item in cualquierarray)
            {
                if (item.ToString().ToLower().Contains(cadena.ToLower()))
                    result += "\n - " + item.ToString().ToLower();
            }
            return result;
        }

        
    }
}
