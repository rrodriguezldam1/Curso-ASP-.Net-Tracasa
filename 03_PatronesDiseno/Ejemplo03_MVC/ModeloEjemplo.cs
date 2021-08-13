using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class ModeloEjemplo
    {
        private List<Ejemplo> ejemplos;

        public ModeloEjemplo()
        {
            ejemplos = new List<Ejemplo>();
        }

        public void Nuevo(Ejemplo ejemplo)
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
    }
}
