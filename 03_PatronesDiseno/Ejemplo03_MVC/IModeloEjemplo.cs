using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    interface IModeloEjemplo
    {
        void Crear(int entero, string str);
        IEnumerable<Ejemplo> LeerTodos();
    }
}
