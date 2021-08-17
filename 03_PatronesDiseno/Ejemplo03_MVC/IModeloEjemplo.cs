using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    interface IModeloEjemplo
    {
        Ejemplo Crear(int entero, string str);
        IList<Ejemplo> LeerTodos();
        Ejemplo LeerUno(string nombre);
        Ejemplo LeerUno(int entero);
        Ejemplo Modificar(string nombreBusq, int entero, string str);
        bool EiminarUno(string nombre);
    }
}
