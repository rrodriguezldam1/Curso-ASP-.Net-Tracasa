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

        public void Crear(string key, int entero, string str) {
            diccionario.Add(key, new Ejemplo(entero, str));
        }

        public void Crear(int entero, string str)
        {
            Crear(str + "-" + entero, entero, str);
        }

        public void LeerTodos(out Dictionary<string, Ejemplo> todos) {
            todos = diccionario;
        }

        public IEnumerable<Ejemplo> LeerTodos()
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
    }
}
