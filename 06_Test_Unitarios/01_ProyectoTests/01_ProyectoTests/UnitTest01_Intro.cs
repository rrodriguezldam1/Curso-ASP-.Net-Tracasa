using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace _01_ProyectoTests
{
    //public class Tests
    //{
    //    string texto = "";
    //    // Este es el método de inicialización porque lleva el atributo C# [Setup]
    //    // Los atributos son "decoradores", características que añadimos a clases, propiedades y métodos.
    //    // Para agregar cierta funcionalidad.
    //    [SetUp]
    //    public void Inicializacion()
    //    {
    //        texto = "Texto Inicial";
    //    }

    //    //[TearDown]
    //    //public void CleanUp()
    //    //{
    //    //    texto = "Clean";
    //    //}

    //    [Test]
    //    public void TestPrimero()
    //    {
    //        // Assert = asegurar
    //        Assert.Pass();
    //    }

    //    [Test]
    //    public void TestSegundo() {
    //        Assert.AreEqual(1 + 3, 2 + 2);
    //        Assert.AreNotEqual(1 + 5, 2 + 2);
    //        Assert.IsNotNull(texto, "Texto es nulo");
    //    }

    //    [Test]
    //    public void Test3()
    //    {
    //        Assert.IsTrue(texto.Equals("Texto Inicial"),"El texto no coincide");
    //    }

    //    [Test]
    //    public void TestTercero()
    //    {
    //        Assert.IsTrue(texto.Length > 5);
    //        int num1 = 0;
    //        num1--;
    //        Assert.NotZero(num1);
    //        int num2 = 0;
    //        num2++;
    //        Assert.Less(num1, num2);
    //    }

    //    [Test]
    //    public void TestCuarto()
    //    {
    //        int num1 = 22;
    //        int num2 = 22;
    //        Assert.GreaterOrEqual(num1, num2);
    //        num2 = num1;
    //        //Assert.AreSame(num1, num2, "No son el mismo objeto");
    //    }

    //    public static void DelegadoCualquieraOk() {
    //        Console.WriteLine("Delegado Cualquiera OK");
    //    }

    //    public static void DelegadoCualquieraMal()
    //    {
    //        throw new NotImplementedException("Delegado Cualquiera Mal");
    //    }

    //    [Test]
    //    public void TestQuinto()
    //    {
    //        TestDelegate delegateOk = DelegadoCualquieraOk;
    //        Assert.DoesNotThrow(delegateOk, "El delegado Cualquiera Ok falló");
    //        Assert.Throws<NotImplementedException>(DelegadoCualquieraMal, "El delegado Cualquiera Mal cascó");
    //    }
    //}

    [TestFixture]
    public class AssertThrowsTests
    {
        [Test(Author = "Ramón RL", Description = "Recoger una excepción asíncrona")]
        public void TestThrowsAsync()
        {
            // Using a method as a delegate
            Assert.ThrowsAsync<ArgumentException>(async () => await MethodThatThrows());
        }

        async Task MethodThatThrows()
        {
            Console.WriteLine("UNO");
            await Task.Delay(3000);
            Console.WriteLine("DOS");
            var t = Task.Run(delegate
            {
                Task.Delay(2000);
                Console.WriteLine("TRES");
            });
            //t.Wait();
            Console.WriteLine("CUATRO");
            throw new ArgumentException();
        }
    }
}