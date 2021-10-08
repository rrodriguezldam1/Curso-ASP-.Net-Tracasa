using NUnit.Framework;
using ModeloUsuarios;
using System;
using System.Reflection;

namespace TestModeloUsuario
{
    public class TestsControladorYModelosUsuarios
    {
        ModeloUsuario modelo;
        Controlador controlador;
        ModuloPersistencia moduloPersistencia;
        Usuario usu1;

        void LimpiarJSON()
        {
            // string path = "C:/Users/pmpcurso1/Desktop/hola.json";
            System.IO.File.Delete(ModuloPersistencia.Fichero);
            // System.IO.File.WriteAllText(ModuloPersistencia.Fichero, "[]");
        }
        void ResetearModeloYCtrl_ConReflection ()
        {
            // FieldInfo[] camposModelo = ModeloUsuario.Instancia.GetType().GetFields(...);
            FieldInfo[] camposModelo = typeof(ModeloUsuario).GetFields(
                BindingFlags.NonPublic | BindingFlags.Static);
            foreach (FieldInfo campo in camposModelo)
            {
                if (campo.Name.Equals("instance"))
                {
                    ModeloUsuario.Instancia.ToString();
                    Console.WriteLine("Encontrado instance Modelo y eliminado");
                    campo.SetValue(null, null);
                    ModeloUsuario.Instancia.ToString();
                }
            }
            moduloPersistencia = new ModuloPersistencia(Entorno.Desarrollo);
            modelo = ModeloUsuario.Instancia;
            controlador = new Controlador(modelo);
            //  type.GetField("instance", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, null);
        }
        void EliminarTodosUsuarios()
        {
            // var lista = ModeloUsuario.Instancia.LeerTodos();

            while (ModeloUsuario.Instancia.LeerTodos().Count > 0)
            {
                ModeloUsuario.Instancia.Eliminar(0);
            }
            /*while (ModeloUsuario.Instancia.LeerTodos().Count > 0)
            {
                var primero = ModeloUsuario.Instancia.LeerTodos()[0];
                ModeloUsuario.Instancia.Eliminar(primero.Nombre);
            }*/
        }

        [SetUp]
        public void Setup()
        {
            moduloPersistencia = new ModuloPersistencia(Entorno.Desarrollo);
            modelo = ModeloUsuario.Instancia;
            controlador = new Controlador(modelo);
        }
        [TearDown]
        public void AlTerminarTest()
        {
            // ResetearModeloYCtrl_ConReflection();
            EliminarTodosUsuarios();
            if ((new Random()).Next(3) == 0)
                LimpiarJSON();
        }
        
        void CrearUsuariosValidos()
        {
            usu1 = new Usuario("hola", 27, 1.5f);
            controlador.Crear(usu1);
            controlador.Crear(new Usuario("adios", 33, 2));
            controlador.Crear(new Usuario("qtal", 45, 2));
        }
           
        [Test]
        public void TestCrearValidos()
        {
            CrearUsuariosValidos();
            controlador.Crear(new Usuario("adios2", -3, 2.2f));
            controlador.Crear(new Usuario("qtal2", 400, 27));
            Assert.AreEqual(1, controlador.LeerUno(3).Edad);
            Assert.AreEqual(1.0f, controlador.LeerUno(4).Altura);
            Assert.AreEqual("hola", controlador.LeerUno(0).Nombre);
            Assert.Null(controlador.LeerUno(6));
            Assert.AreEqual(controlador.LeerTodos().Count, 5, "Mal creados los usuarios");
            Assert.IsTrue(controlador.LeerUno(0).Equals(new Usuario("hola", 27, 1.5f)));
        }

        [Test]
        public void TestCrearInvalidos()
        {
            controlador.Crear(new Usuario(null, 400, 27));
            controlador.Crear(null);
            Assert.AreEqual(controlador.LeerTodos().Count, 0, "Mal creados los usuarios");
        }

            [Test]
        public void TestModificar()
        {
            CrearUsuariosValidos();
            Usuario usu1mod = new Usuario("hola", -3, 7);//Te lo cambia aquí directamente
            controlador.Modificar(usu1mod);
            Assert.AreNotEqual(controlador.LeerUno(0), usu1);
            Assert.AreEqual(controlador.LeerUno(0), usu1mod);
            Usuario usuNoExiste = new Usuario("NoExisto",88 ,88 );
            controlador.Modificar(usuNoExiste);
            for(int i=0;i< controlador.LeerTodos().Count; i++)
            {
                Assert.AreNotEqual(controlador.LeerUno(i), usuNoExiste);
            }
        }
       

        [Test]
        public void TestEliminar()
        {
            Usuario usu1 = new Usuario("hola", 1, 1);
            controlador.Crear(usu1);
            controlador.Crear(new Usuario("adios", 43, 2));
            controlador.Crear(new Usuario("qtal", 40, 2));
            Usuario usu = controlador.LeerTodos()[1];
            Assert.AreEqual(true, controlador.Eliminar(1));
            foreach(Usuario usuario in controlador.LeerTodos())
            {
                Assert.AreEqual(false, usuario == usu);
            }
            Assert.AreEqual(2, controlador.LeerTodos().Count);
            Assert.AreEqual(false, controlador.Eliminar(5));
            Assert.AreEqual(2, controlador.LeerTodos().Count);
        }

        [Test]
        public void TestLeerUno()
        {
            Usuario usu1 = new Usuario("hola", 1, 1);
            controlador.Crear(usu1);
            controlador.Crear(new Usuario("adios", 43, 2));
            controlador.Crear(new Usuario("qtal", 40, 2));
            Assert.Null(controlador.LeerUno(4));
            Assert.NotNull(controlador.LeerUno(1));
            Assert.IsInstanceOf<Usuario>(controlador.LeerUno(1));
       
        }
        
        [Test]
        public void TestLeerTodos()
        {
            Assert.AreEqual(0, controlador.LeerTodos().Count);
            controlador.Crear(new Usuario("adios", 43, 2));
            controlador.Crear(new Usuario("qtal", 40, 2));
            Assert.AreEqual(2, controlador.LeerTodos().Count);
            controlador.Eliminar(0);
            Assert.AreEqual(1, controlador.LeerTodos().Count);

        }
        [Test]
        public void ProbarGuardadoFichero()
        {
            TestCrearValidos();

            ResetearModeloYCtrl_ConReflection();

            Assert.IsTrue(controlador.LeerUno(4).Equals(new Usuario("qtal2", 400, 27)));
        }
    }

}