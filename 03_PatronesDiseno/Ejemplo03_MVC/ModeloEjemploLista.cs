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

        public void Crear(Ejemplo ejemplo)
        {
            ejemplos.Add(ejemplo);
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

        public void Crear(int entero, string str)
        {
            Crear(new Ejemplo(entero, str));
        }

        IEnumerable<Ejemplo> IModeloEjemplo.LeerTodos()
        {
            return LeerTodos();
        }
    }
}
