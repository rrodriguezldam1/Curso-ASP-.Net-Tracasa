using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    interface IModeloGenerico<Tipo>
    {
        Tipo Crear(Tipo nuevoObj);
        IList<Tipo> LeerTodos();
        Tipo LeerUno(int entero);
        bool Eliminar(int entero);
    }
}
