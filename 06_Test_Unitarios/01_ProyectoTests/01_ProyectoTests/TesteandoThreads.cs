using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _01_ProyectoTests
{
    class TesteandoThreads
    {
        [Test]
        public void ProbandoHilos() {
            Console.WriteLine("Arrancando probando hilos");
            Thread t1 = new Thread(FuncionHilo1);
            Thread t2 = new Thread(FuncionHilo2);
            t1.Start();
            t2.Start();
            Console.WriteLine("Terminando t.Start()");
            Thread.Sleep(1000);
            Console.WriteLine("Terminando probando hilos");
        }
        static int i = 0;
        public static void FuncionHilo1()
        {
            Console.WriteLine("Arrancando hilo 1");
            for (i = 0; i < 100000000; i++) ;
            Console.WriteLine("Terminando hilo 1");
        }

        public static void FuncionHilo2()
        {
            Console.WriteLine("Arrancando hilo 2");
            for (i = 10000000; i > 0; i--) ;
            Console.WriteLine("Terminando hilo 2");
        }
    }
}
