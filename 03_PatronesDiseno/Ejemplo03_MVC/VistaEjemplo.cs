using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class VistaEjemplo
    {
        ModeloEjemplo modelo;
        public VistaEjemplo(ModeloEjemplo modelo)
        {
            this.modelo = modelo;
        }

        public void MostrarEjemplos()
        {
            IList<Ejemplo> todos = modelo.LeerTodos();
            foreach (Ejemplo ejemplo in todos)
            {
                Console.WriteLine("Ejemplo " + ejemplo.ToString());
            }
        }
        public void MostrarUno(string s)
        {
            Ejemplo ejemplo = modelo.LeerUno(s);
            if (ejemplo != null)
                Console.WriteLine("Ejemplo " + ejemplo.ToString());
            else
                Console.WriteLine("No encontrado por " + s);
        }
    }
}
