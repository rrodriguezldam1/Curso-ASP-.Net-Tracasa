using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class ModeloMuestra : IModeloMuestra
    {
        public Muestra Crear(Muestra nuevoObj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int entero)
        {
            throw new NotImplementedException();
        }

        public IList<Muestra> LeerTodos()
        {
            throw new NotImplementedException();
        }

        public Muestra LeerUno(int entero)
        {
            throw new NotImplementedException();
        }
    }
}
