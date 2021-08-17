using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class ModeloEjemploLista : IModeloEjemplo
    {
        private List<Ejemplo> ejemplos;

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
                if (ejemplo.Entero == entero)
                    return ejemplo;
            }
            return null;
        }

        IList<Ejemplo> IModeloEjemplo.LeerTodos()
        {
            return LeerTodos();
        }

        public void EiminarUno(string nombre)
        {
            foreach (Ejemplo ejemplo in ejemplos)
            {
                if (ejemplo.Str == nombre)
                {
                    ejemplos.Remove(ejemplo);
                    break;
                }
            }
        }

        //public Ejemplo Modificar(string nombreBusq, int entero, string str)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IModeloEjemplo.EiminarUno(string nombre)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
