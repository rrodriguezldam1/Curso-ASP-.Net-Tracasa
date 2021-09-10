using Ejemplo03_MVC.DLL.Modelo.Entidades;
using Ejemplo03_MVC.DLL.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Modelo

{
    public class ModeloEjemDiccionario : IModeloEjemplo
    {
        Dictionary<string, Ejemplo> diccionario;

        public ModeloEjemDiccionario()
        {
            diccionario = new Dictionary<string, Ejemplo>();
        }

        public IModeloGenerico<Ejemplo> Instancia => throw new NotImplementedException();

        public Ejemplo Crear(Ejemplo ejemplo)
        {
            throw new NotImplementedException("No se puede por la clave");
            //TODO: Leer propiedad privada mediante REFLECTION
        }
        public Ejemplo Crear(string key, int entero, string str)
        {
            Ejemplo ej = new Ejemplo(entero, str);
            // diccionario.TryAdd       Hace algo parecido
            if (diccionario.ContainsKey(key))
            {
                ej = null;
                // diccionario[key] = ej;   // Si quisieramos sustituir, así
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

        public bool Eliminar(string nombre)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.Str.Equals(nombre))
                {
                    diccionario.Remove(item.Key);
                    return true;
                }
            }
            return false;
        }
        public bool Eliminar(int entero)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.EsEntero(entero))
                {
                    diccionario.Remove(item.Key);
                    return true;
                }
            }
            return false;
        }
        public void LeerTodos(out Dictionary<string, Ejemplo> todos)
        {
            todos = diccionario;
        }

        public IList<Ejemplo> LeerTodos()
        {
            List<Ejemplo> lista = new List<Ejemplo>();
            foreach (var item in diccionario)
            {
                lista.Add(item.Value);
            }
            return lista;
        }

        public Ejemplo LeerUno(string nombre)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.Str.Equals(nombre))
                {
                    return item.Value;
                }
            }
            return null;
        }
        public Ejemplo LeerUno(int ent)
        {
            foreach (var item in diccionario)
            {
                if (item.Value.EsEntero(ent))
                {
                    return item.Value;
                }
            }
            return null;
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

        public Ejemplo Modificar(Ejemplo nuevoObj)
        {
            throw new NotImplementedException();
        }
    }
}
