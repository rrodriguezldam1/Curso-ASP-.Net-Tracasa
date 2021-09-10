
using Ejemplo03_MVC.DLL.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Modelo.Interfaces
{
    public interface IModeloEjemplo : IModeloGenerico<Ejemplo>
    {
        Ejemplo Crear(int entero, string str);
        // IList<Ejemplo> LeerTodos();
        public Ejemplo LeerUno(string nombre);
        // public Ejemplo LeerUno(int entero);
         
         Ejemplo Modificar(string nombreBusq, int entero, string str);
        public bool Eliminar(string nombre);
    }
}
