using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloUsuarios
{
    public class Controlador
    {
        IModeloGenerico<Usuario> modeloUsuario;

        public Controlador(IModeloGenerico<Usuario> modelo)
        {
            this.modeloUsuario = modelo;
        }

        public void Crear(Usuario nuevoObj)
        {
            modeloUsuario.Crear(nuevoObj);
        }

        public IList<Usuario> LeerTodos()
        {
            return modeloUsuario.LeerTodos();
        }

        public bool Eliminar(int entero)
        {
            return modeloUsuario.Eliminar(entero);
        }

        public Usuario LeerUno(int entero)
        {
            return modeloUsuario.LeerUno(entero);
        }
        public bool LeerConfirmar(string nombre)
        {
            return modeloUsuario.LeerConfirmar(nombre);
        }

        public void Modificar(Usuario usuario)
        {
            modeloUsuario.Modificar(usuario);
        }
    }
}
