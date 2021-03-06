using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class ControladorEjemplo
    {
        IModeloEjemplo modelo;

        public ControladorEjemplo(IModeloEjemplo modelo) {
            this.modelo = modelo;
        }

        public Ejemplo AltaEjemplo(int entero, string str) {
            return modelo.Crear(entero, str);
        }

        public IEnumerable<Ejemplo> LeerEjemplos()
        {
            return modelo.LeerTodos();
        }

        public Ejemplo LeerUno(string nombre) {
            return modelo.LeerUno(nombre);
        }

        public Ejemplo LeerUno(int entero)
        {
            return modelo.LeerUno(entero);
        }

        public bool EliminarUno(string nombre)
        {
            return modelo.EiminarUno(nombre);
        }

        public Ejemplo Modificar(string nombreBusq, int entero, string str)
        {
            return modelo.Modificar(nombreBusq, entero, str);
        }
    }
}
