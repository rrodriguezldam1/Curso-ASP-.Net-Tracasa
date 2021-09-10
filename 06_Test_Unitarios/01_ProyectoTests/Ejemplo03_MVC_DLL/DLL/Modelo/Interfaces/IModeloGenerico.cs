using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Modelo.Interfaces
{
    public interface IModeloGenerico<Tipo> {
        IModeloGenerico<Tipo> Instancia
        {
            get;
        }
	// Metodo Crear
        Tipo Crear(Tipo nuevoObj);
	// Metodo Modificar
        Tipo Modificar(Tipo nuevoObj);
	// Metodo Eliminar
        bool Eliminar(int entero);

        IList<Tipo> LeerTodos();

        Tipo LeerUno(int entero);
    }
}
