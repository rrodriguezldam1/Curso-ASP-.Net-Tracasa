using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloUsuarios
{
    public interface IModeloGenerico<Tipo>
    {
        void Crear(Tipo nuevoObj);
        IList<Tipo> LeerTodos();
        Tipo LeerUno(int entero);
        bool Eliminar(int entero);

        bool LeerConfirmar(string nombre);

        void Modificar(Usuario usuario);
    }
}
