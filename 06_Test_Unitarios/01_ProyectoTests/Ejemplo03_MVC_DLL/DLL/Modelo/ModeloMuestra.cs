
using Ejemplo03_MVC.DLL.Modelo.Entidades;
using Ejemplo03_MVC.DLL.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Modelo
{
    class ModeloMuestra //: IModeloGenerico<Muestra>
                        : IModeloMuestra
    {
        public IModeloGenerico<Muestra> Instancia => throw new NotImplementedException();

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

        public Muestra Modificar(Muestra nuevoObj)
        {
            throw new NotImplementedException();
        }
    }
}
