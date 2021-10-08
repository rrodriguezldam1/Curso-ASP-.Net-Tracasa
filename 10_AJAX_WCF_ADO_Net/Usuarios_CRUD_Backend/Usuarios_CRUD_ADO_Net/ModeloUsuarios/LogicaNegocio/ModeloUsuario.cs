using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloUsuarios
{
    public delegate void CrearUsuario(Usuario usuario);
    public delegate bool EliminarUsuario(int entero);
    public delegate IList<Usuario> LeerTodo();
    public delegate Usuario LeerUno(int entero);
    public delegate bool LeerConfimar(string nombre);
    public delegate void Modificar(Usuario usu);

    public class ModeloUsuario : IModeloUsuario
    {
        static ModeloUsuario instance = null;
        public CrearUsuario delegadoCrear;
        public EliminarUsuario delegadoEliminar;
        //public LeerUsuario delegateLeer;

        public LeerTodo leerTodo;
        public LeerUno leerUno;
        public LeerConfimar leerConfirmar;
        public Modificar modificar;
        public ModeloUsuario() // Contructor de la clase que queremos que solo haya una instancia, se debe poner como private
        {

        }

        public static ModeloUsuario Instancia
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModeloUsuario();
                }

                return instance;
            }
        }

        public void Crear(Usuario nuevoObj)
        {
            if (nuevoObj != null)
            {
                if (! string.IsNullOrEmpty(nuevoObj.Nombre) && nuevoObj.Nombre != "SIN NOMBRE")
                {
                    delegadoCrear?.Invoke(nuevoObj);
                }                
            }
        }

        public bool Eliminar(int entero)
        {
           return delegadoEliminar.Invoke(entero);
        }

        public IList<Usuario> LeerTodos()
        {
            return leerTodo?.Invoke();
        }

        public Usuario LeerUno(int entero)
        {

            return leerUno?.Invoke(entero);
        }

        public bool LeerConfirmar(string nombre)
        {
            
            return leerConfirmar.Invoke(nombre);
        }

        public void Modificar(Usuario usuario)
        {
            modificar?.Invoke(usuario);
        }
    }
}
