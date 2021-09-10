using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Ejemplo03_MVC.DLL.Modelo;
using Ejemplo03_MVC.DLL.Modelo.Interfaces;

namespace Ejemplo03_MVC.Test
    {
        [TestFixture]
        public class TestModeloEjemplo
        {
            [Test(Author = "Ramón RL", Description = "Probando Modelo Ejemplo")]
            public void TestModeloListaEjemplo()
            {
                IModeloEjemplo model1;
                model1 = new ModeloEjemploLista();

                model1.Crear(1, "Uno");
                model1.Crear(2, "Dos");
                model1.Crear(3, "Tres");

                Assert.AreEqual(model1.LeerTodos().Count, 3);
            }
        }
}