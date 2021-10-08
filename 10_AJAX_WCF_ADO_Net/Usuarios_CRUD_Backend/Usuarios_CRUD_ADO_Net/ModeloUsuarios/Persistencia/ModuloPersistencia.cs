using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

using System.Text.Json.Serialization;

namespace ModeloUsuarios
{
    public enum Entorno
    {
        Ninguno = 0,
        Produccion = 1,
        Desarrollo = 2,
        Preproduccion = 3,
    }
    public class ModuloPersistencia
    {
        const string DIR_DATA = "GestionUsuarios";
        static Entorno entorno = Entorno.Desarrollo;
        ModeloUsuario modelo;

        List<Usuario> listaUsuarios = new List<Usuario>();

        static public string Directorio { get { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                + "\\" + DIR_DATA + (entorno == Entorno.Produccion ? "\\Produccion" : "\\Desarrollo"); } }
        static public string Fichero {  get
            {
                return Directorio + "\\" + "datos_usuarios.json";
            } }

        public ModuloPersistencia(Entorno entorno)
        {
            ModuloPersistencia.entorno = entorno;

            if (! Directory.Exists(Directorio))
            {
                Directory.CreateDirectory(Directorio);
            }
            Console.WriteLine("Directorio: " + Directorio);
            ModeloUsuario.Instancia.delegadoCrear = Crear;
            ModeloUsuario.Instancia.delegadoEliminar = Eliminar;
            ModeloUsuario.Instancia.leerTodo = LeerTodo;
            ModeloUsuario.Instancia.leerUno = LeerUno;
            ModeloUsuario.Instancia.leerConfirmar = LeerConfirmar;
            ModeloUsuario.Instancia.modificar = Modificar;
            listaUsuarios = Leer();
        }
        //public void Guardar(List<Usuario> usus)
        public void Crear(Usuario usuario)
        {
            bool existe = false;
            foreach(Usuario usu in LeerTodo())
            {
                if(usu.Nombre == usuario.Nombre)
                {
                    existe = true;
                    break;
                } else
                {
                    existe = false;

                }
            }
            if (!existe) {
                listaUsuarios.Add(usuario);
                Guardar(listaUsuarios);
            }
        }
        
        public  void Guardar(List<Usuario> usus)
        {
            JsonSerializerOptions js = new JsonSerializerOptions();
            js.WriteIndented = true;
            System.IO.File.WriteAllText(Fichero, JsonSerializer.Serialize<List<Usuario>>(usus, js));
        }
        public bool Eliminar(int entero)
        {
            if(listaUsuarios.Count > entero)
            {
                listaUsuarios.RemoveAt(entero);
                Guardar(listaUsuarios);
                return true;
            } else
            {
                return false;
            }
        }
        public  List<Usuario> Leer()
        {
            try {
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(System.IO.File.ReadAllText(Fichero));
            } catch
            {
                listaUsuarios = new List<Usuario>();
            }            
            return listaUsuarios;
        }

        public IList<Usuario> LeerTodo()
        {
            return listaUsuarios;
        }

        public Usuario LeerUno(int entero)
        {
            if(listaUsuarios.Count > entero)
            {
                return listaUsuarios[entero];
            } else
            {
                return null;
            }
        }

        public bool LeerConfirmar(string nombre)
        {
            int posicion = 0;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (listaUsuarios[i].GetNombre() == nombre)
                {
                    posicion = i;
                    return true;
                }
            }
            return false;
        }

        public void Modificar(Usuario usu)
        {
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (listaUsuarios[i].GetNombre() == usu.GetNombre())
                {
                    listaUsuarios[i] = usu;
                }
            }
            Guardar(listaUsuarios);
        }
    }
}
