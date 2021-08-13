using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class VistaEjemplo
    {
        IModeloEjemplo modelo;

        public VistaEjemplo(IModeloEjemplo modelo)
        {
            this.modelo = modelo;
        }

        public void AltaEjemplo() {
            Console.WriteLine("Alta ejemplo: numero:");
            int entero = int.Parse(Console.ReadLine());
            Console.WriteLine("Alta ejemplo: string:");
            string str = Console.ReadLine();
            this.modelo.Crear(entero, str);
        }

        public void MostrarEjemplos()
        {
            IEnumerable<Ejemplo> todos = modelo.LeerTodos();
            foreach (Ejemplo ejemplo in todos)
            {
                Console.WriteLine("Ejemplo " + ejemplo.ToString());
            }
        }
        /*
        public void MostrarUno(string s)
        {
            Ejemplo ejemplo = modelo.LeerUno(s);
            if (ejemplo != null)
                Console.WriteLine("Ejemplo " + ejemplo.ToString());
            else
                Console.WriteLine("No encontrado por " + s);
        }
        */
    }
}
