using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo02_Factoria
{
    class FactoriaProducto
    {
        /*public Producto Crear()
        {
            return new Producto();
        }
        public Producto Crear(int e)
        {
            return new Producto(e);
        }*/

        public Producto Crear(int id)
        {
            string nombre;
            switch (id) {
                case 1: nombre = "Uno"; break;
                case 2: nombre = "Dos"; break;
                case 3: nombre = "Tres"; break;
                case 4: nombre = "Cuatro"; break;
                default: nombre = "Otro a saber"; break;
            }
            return new Producto(id, nombre);
        }
        public Producto Crear(int id, string nombre)
        {
            return new Producto(id, nombre);
        }
        public List<Producto> CrearLista(int a, int b)
        {
            List<Producto> lista = new List<Producto>();
            for (int i = a; i <= b; i++) { lista.Add(Crear(i)); }
            return lista;
        }

        public List<Producto> CrearLista(int b)
        {
            return CrearLista(1, b);
        }

        public List<Producto> CrearLista(int[] ids)
        {
            List<Producto> l = new List<Producto>();
            for (int i = 0; i < ids.Length; i++)
            {
                l.Add(Crear(ids[i]));
            }
            return l;
        }
    }
}
