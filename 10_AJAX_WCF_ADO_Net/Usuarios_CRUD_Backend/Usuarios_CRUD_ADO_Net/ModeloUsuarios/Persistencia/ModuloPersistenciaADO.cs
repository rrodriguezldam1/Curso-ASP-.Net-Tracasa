using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.Json;

using System.Text.Json.Serialization;

namespace ModeloUsuarios
{
    public class ModuloPersistenciaADO
    {
        const string CONEX_BD = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename" +
            "=C:\\BD\\bd_usu.mdf;Integrated Security=True;Connect Timeout=30";
        static Entorno entorno = Entorno.Desarrollo;
        ModeloUsuario modelo;

        List<Usuario> listaUsuarios = new List<Usuario>();

        public ModuloPersistenciaADO(Entorno entorno)
        {
            ModuloPersistenciaADO.entorno = entorno;

            ModeloUsuario.Instancia.delegadoCrear = Crear;
            ModeloUsuario.Instancia.delegadoEliminar = Eliminar;
            ModeloUsuario.Instancia.leerTodo = LeerTodo;
            ModeloUsuario.Instancia.leerUno = LeerUno;
            ModeloUsuario.Instancia.leerConfirmar = LeerConfirmar;
            ModeloUsuario.Instancia.modificar = Modificar;
            listaUsuarios = Leer();
        }

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
            //TODO: Guardar en base de datos: ejecutar INSERTS
            try
            {
                SqlConnection conexion;

                using (conexion = new SqlConnection(CONEX_BD))
                {
                    conexion.Open();

                    foreach (Usuario u in listaUsuarios)
                    {
                        SqlCommand comando = conexion.CreateCommand();
                        comando.CommandText = "insert into Usuario " +
                            "(nombre, email, edad, altura, activo) " +
                            "values('" + u.Nombre + "', '" +
                                u.Nombre.ToLower().Replace(' ', '_') +
                                "@email.es', " + u.Altura + ", " +
                                u.Edad + ", 0)";
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas != 1)
                            throw new Exception("No ha hecho insert bbdd " + comando.CommandText);
                    }
                } //conexion.Close()
                Console.WriteLine("Leídos en bbdd: " + listaUsuarios.Count);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error leyendo bbdd: " + ex.Message);
            }
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
            listaUsuarios = new List<Usuario>();
            try
            {
                SqlConnection conexion;

                using (conexion = new SqlConnection(CONEX_BD))
                {
                    conexion.Open();

                    Usuario usuario;
                    SqlCommand comando = conexion.CreateCommand();
                    comando.CommandText = "insert into Usuario nombre, edad, altura from Usuario;";
                    SqlDataReader lectorDR = comando.ExecuteReader();

                    while (lectorDR.Read())
                    {
                        usuario = new Usuario();
                        usuario.Nombre = lectorDR[0].ToString();
                        usuario.Edad = lectorDR.GetByte(1);
                        usuario.Altura = (float)(double)lectorDR[2];
                        listaUsuarios.Add(usuario);
                    }
                } //conexion.Close()
                Console.WriteLine("Leídos en bbdd: " + listaUsuarios.Count);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error leyendo bbdd: " + ex.Message);
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
