using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    public class ModeloEjemDiccionario : IModeloEjemplo
    {
        Dictionary<string, Ejemplo> diccionario;

        public ModeloEjemDiccionario() {
            diccionario = new Dictionary<string, Ejemplo>();
        }

        public Ejemplo Crear(string key, int entero, string str) {
            Ejemplo ej = new Ejemplo(entero, str);
            if (diccionario.ContainsKey(key))
            {
                ej = null;
                //diccionario[key] = ej;
            }
            else
            {
                diccionario.Add(key, ej);
            }
            return ej;
        }

        public Ejemplo Crear(int entero, string str)
        {
            string clave = str + "-" + entero;
            return Crear(clave, entero, str);
        }

        public void LeerTodos(out Dictionary<string, Ejemplo> todos) {
            todos = diccionario;
        }

        public IList<Ejemplo> LeerTodos()
        {
            IList<Ejemplo> enumerable = new List<Ejemplo>();
            foreach (var item in diccionario)
            {
                enumerable.Add(item.Value);
            }
            return enumerable;
        }

        public Ejemplo LeerUno(string nombre)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.Str.Equals(nombre))
                    return item.Value;
            }
            return null;
        }

        public Ejemplo LeerUno(int entero)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.Entero.Equals(entero))
                    return item.Value;
            }
            return null;
        }

        public bool EiminarUno(string nombre)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.Str.Equals(nombre))
                {
                    return diccionario.Remove(item.Key);
                }
            }
            return false;
        }

        public Ejemplo Modificar(string nombreBusq, int entero, string str)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.Str.Equals(nombreBusq))
                {
                    Ejemplo nuevoEjemploModificado = new Ejemplo(entero, str);
                    string clave = item.Key;
                    diccionario[clave] = nuevoEjemploModificado;
                    return nuevoEjemploModificado; // item.Value;
                }
                    
            }
            return null;
        }
    }
}
