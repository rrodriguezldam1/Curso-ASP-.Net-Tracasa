
using Ejemplo03_MVC.DLL.Modelo.Entidades;
using Ejemplo03_MVC.DLL.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Modelo
{
    public class ModeloEjemploLista : IModeloEjemplo
    {
        private List<Ejemplo> ejemplos;

        public IModeloGenerico<Ejemplo> Instancia => throw new NotImplementedException();

        public ModeloEjemploLista()
        {
            ejemplos = new List<Ejemplo>();
        }

        public Ejemplo Crear(Ejemplo ejemplo)
        {
            ejemplos.Add(ejemplo);
            return ejemplo;
        }

        public Ejemplo Crear(int entero, string str)
        {
            return Crear(new Ejemplo(entero, str));
        }

        public bool Eliminar(string nombre)
        {
            Ejemplo ejemplo = LeerUno(nombre);
            if (ejemplo != null)
            {
                return ejemplos.Remove(ejemplo);
            }
            return false;
        }
        public bool Eliminar(int entero)
        {
            Ejemplo ejemplo = LeerUno(entero);
            if (ejemplo != null)
            {
                return ejemplos.Remove(ejemplo);
            }
            return false;
        }

        public List<Ejemplo> LeerTodos()
        {
            return ejemplos;
        }
        public Ejemplo LeerUno(string str)
        {
            foreach (Ejemplo ejemplo in ejemplos)
            {
                if (ejemplo.Str == str)
                    return ejemplo;
            }
            return null;
        }

        public Ejemplo LeerUno(int entero)
        {
            foreach (Ejemplo ejemplo in ejemplos)
            {
                if (ejemplo.EsEntero(entero))
                    return ejemplo;
            }
            return null;
        }

        IList<Ejemplo> IModeloGenerico<Ejemplo>.LeerTodos()
        {
            return LeerTodos();
        }

        public Ejemplo Modificar(string nombreBusq, int entero, string str)
        {
            Ejemplo ejemploAmodif = LeerUno(nombreBusq);
            if (ejemploAmodif == null)
                return null;
            int posicion = ejemplos.IndexOf(ejemploAmodif);
            ejemplos[posicion] = new Ejemplo(entero, str);
            return ejemplos[posicion];
        }
        /* De esta manera, creamos al final de las lista, alteramos el orden */
        public Ejemplo Modificar2(string nombreBusq, int entero, string str)
        {
            Eliminar(nombreBusq);
            return Crear(entero, str);
        }

        public Ejemplo Modificar(Ejemplo nuevoObj)
        {
            throw new NotImplementedException();
        }
    }
}
