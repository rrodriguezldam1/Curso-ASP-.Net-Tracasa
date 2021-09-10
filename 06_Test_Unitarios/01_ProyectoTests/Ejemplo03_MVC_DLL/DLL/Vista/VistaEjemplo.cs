
using Ejemplo03_MVC.DLL.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo03_MVC.DLL.Vista
{
    public class VistaEjemplo : IVistaEjemplo
    {
        ControladorEjemplo controlador;
        public VistaEjemplo(ControladorEjemplo controlador)
        {
            this.controlador = controlador;
        }
        public void Menu()
        {
            int opcion = 0;
            do   {
                Console.WriteLine("MENU: ( 0 -Salir)");
                Console.WriteLine(" 1 - Alta ejemplo");
                Console.WriteLine(" 2 - Mostrar todos");
                Console.WriteLine(" 3 - Mostrar uno");
                Console.WriteLine(" 4 - Eliminar uno");
                Console.WriteLine(" 5 - Modificar uno");
                string str_op = Console.ReadLine();
                if (int.TryParse(str_op, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AltaEjemplo();
                            break;
                        case 2:
                            MostrarEjemplos();
                            break;
                        case 3:
                            MostrarUno();
                            break;
                        case 4:
                            EliminarUno();
                            break;
                        case 5:
                            ModificarUno();
                            break;
                        default:
                            Console.WriteLine("Introduzca opcion valida");
                            break;
                    }
                } else {
                    opcion = -1;
                    Console.WriteLine("Escribe bien el número");
                }
            } while (opcion != 0);
        }

        public void AltaEjemplo()
        {
            Console.WriteLine("Alta ejemplo: numero:");
            int entero = int.Parse(Console.ReadLine());
            Console.WriteLine("Alta ejemplo: string:");
            string str = Console.ReadLine();
            Ejemplo ej = this.controlador.AltaEjemplo(entero, str);
            if (ej != null)
            {
                Console.WriteLine("Se dio de alta el ejemplo " + ej.ToString());
            } else
            {
                Console.WriteLine("No se dio de alta el ejemplo " + str);
            }
        }
        public void MostrarEjemplos()
        {
            IEnumerable<Ejemplo> todos = controlador.LeerEjemplos();
            foreach (Ejemplo ejemplo in todos)
            {
                Console.WriteLine("Ejemplo " + ejemplo.ToString());
            }
        }
        public void EliminarUno()
        {
            Console.WriteLine("Intro nombre: ");
            string nombre = Console.ReadLine();
            bool eliminado = controlador.EliminarUno(nombre);
            if (eliminado)
                Console.WriteLine("Eliminado " + nombre);
            else
                Console.WriteLine("No encontrado por " + nombre);
        }
        public void MostrarUno()
       {
            Console.WriteLine(" 1 - Busqueda por numero ");
            Console.WriteLine(" 2 - Busqueda por nombre ");
            int opcion;
            string op = Console.ReadLine();
            if (int.TryParse(op, out opcion))
            {
                Ejemplo ejemplo;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Intro entero: ");
                        int entero = int.Parse(Console.ReadLine());
                        ejemplo = controlador.LeerUno(entero);
                        if (ejemplo != null)
                            Console.WriteLine("Ejemplo " + ejemplo.ToString());
                        else
                            Console.WriteLine("No encontrado por " + entero);
                        break;
                    case 2:
                        Console.WriteLine("Intro nombre: ");
                        string nombre = Console.ReadLine();
                        ejemplo = controlador.LeerUno(nombre);
                        if (ejemplo != null)
                            Console.WriteLine("Ejemplo " + ejemplo.ToString());
                        else
                            Console.WriteLine("No encontrado por " + nombre);
                        break;
                }
            }
        }
        public void ModificarUno()
        {
            Console.WriteLine("Intro nombre a buscar: ");
            string nombre = Console.ReadLine();
            if (controlador.LeerUno(nombre) == null)
            {
                Console.WriteLine("No se ha encontrado " + nombre);
            } else
            {
                Console.WriteLine("Nuevo numero:");
                int entero = int.Parse(Console.ReadLine());
                Console.WriteLine("Nuevo string:");
                string str = Console.ReadLine();
                Ejemplo ej = this.controlador.Modificar(nombre, entero, str);

                if (ej != null)
                    Console.WriteLine("Modificado " + ej.ToString());
                else
                    Console.WriteLine("No encontrado por " + nombre);
            }
        }
    }
}
