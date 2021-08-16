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

        public void AltaEjemplo(int entero, string str) {
            modelo.Crear(entero, str);
        }

        public IEnumerable<Ejemplo> LeerEjemplos()
        {
            return modelo.LeerTodos();
        }

        public Ejemplo LeerUno(string nombre) {
            return modelo.LeerUno(nombre);
        }
    }
}
