using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC
{
    class VistaEjemplo : IVistaEjemplo
    {
        ControladorEjemplo controladorEjemplo;

        public VistaEjemplo(ControladorEjemplo controladorEjemplo)
        {
            this.controladorEjemplo = controladorEjemplo;
        }

        public void Menu() {
            bool seguir = true;
            int opc = 0;
            while (seguir)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("====================");
                Console.WriteLine("1.- Alta Ejemplo");
                Console.WriteLine("2.- Mostrar Ejemplo");
                Console.WriteLine("3.- Mostrar Uno");
                Console.WriteLine("4.- Eliminar Uno");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("=====================");
                Console.WriteLine("Introduce opción del menú con numero");
                opc = int.Parse(Console.ReadLine().Trim());
                switch (opc) {
                    case 1:
                        Console.Clear();
                        AltaEjemplo();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear(); 
                        MostrarEjemplos();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        MostrarUno();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Clear();
                        EliminarUno();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Clear();
                        Modificar();
                        Console.WriteLine();
                        break;
                    case 6:
                        seguir = false;
                        Console.WriteLine("Gracias por usar este programa.");
                        break;
                }
            }
        }

        private void Modificar()
        {
            Ejemplo ejemplo;
            Console.WriteLine("Introduce nombre: ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Introduce entero: ");
            int entero = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Introduce nombre: ");
            string str = Console.ReadLine().Trim();
            ejemplo = controladorEjemplo.Modificar(nombre, entero, str);
            if (ejemplo != null) Console.WriteLine(ejemplo.ToString());
            else Console.WriteLine("No se ha encontrado " + nombre);
        }

        public Ejemplo AltaEjemplo() {
            Console.WriteLine("Alta ejemplo: numero:");
            int entero = int.Parse(Console.ReadLine());
            Console.WriteLine("Alta ejemplo: string:");
            string str = Console.ReadLine();
            Ejemplo ej = controladorEjemplo.AltaEjemplo(entero, str);
            if (ej != null) {
                Console.WriteLine("Se dio de alta el ejemplo " + ej.ToString());
                return ej;
            } 
            else
            {
                Console.WriteLine("No se dio de alta el ejemplo ");
                return null;
            }
        }

        public void MostrarEjemplos()
        {
            IEnumerable<Ejemplo> todos = controladorEjemplo.LeerEjemplos();
            foreach (Ejemplo ejemplo in todos)
            {
                Console.WriteLine("Ejemplo " + ejemplo.ToString());
            }
        }
        public void MostrarUno()
        {
            Console.WriteLine("1 - Busqueda por numero ");
            Console.WriteLine("2 - Busqueda por nombre ");
            int opcion;
            string op = Console.ReadLine().Trim();
            if (int.TryParse(op, out opcion))
            {
                Ejemplo ejemplo;
                switch (opcion)
                {        
                    case 1:
                        Console.WriteLine("Introduce numero: ");
                        int numero = int.Parse(Console.ReadLine().Trim());
                        ejemplo = controladorEjemplo.LeerUno(numero);
                        if (ejemplo != null) Console.WriteLine(ejemplo.ToString());
                        else Console.WriteLine("No se ha encontrado " + numero);
                        break;
                    case 2:
                        Console.WriteLine("Introduce nombre: ");
                        string nombre = Console.ReadLine().Trim();
                        ejemplo = controladorEjemplo.LeerUno(nombre);
                        if (ejemplo != null) Console.WriteLine(ejemplo.ToString());
                        else Console.WriteLine("No se ha encontrado " + nombre);
                        break;
                }
            }
            else {
                Console.WriteLine("No es válida esa opción " + op);
            }
        }
        public void EliminarUno() {
            bool esEliminado = false;
            Console.WriteLine("Eliminar...");
            Console.WriteLine("Introduce nombre: ");
            string nombre = Console.ReadLine().Trim();
            esEliminado = controladorEjemplo.EliminarUno(nombre);
            if (esEliminado) Console.WriteLine("El ejemplo con nombre " + nombre + " ha sido eliminado");
            else Console.WriteLine("El ejemplo con nombre " + nombre + " no ha sido encontrado");
        }
    }
}
