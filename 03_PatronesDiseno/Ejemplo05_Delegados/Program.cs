using System;

namespace Ejemplo05_Lambdas
{
    // Vamos a crear un nuevo tipo de dato, que en vez de 
    // almacenar información, almacene una función con 
    // determinada estructura ó firma.
    // La estructura es como la interfaz de una función, 
    // pero sin importar el nombre: es decir los tipos de
    // datos que recibe, y el tipo de dato que devuelve.
    // En C eran punteros a funciones, en Java hasta Java 8,
    // eran interfaces con una sola función, en JS funciones
    // flechas, en C# son los delegados.
    delegate void FuncionQueRecibeInt(int param);
    //delegate void funExt(int num);

    class Program
    {
        static void Main(string[] args)
        {
            //LAMBDAS
            // Invocar funciones estáticas:
            FuncionEstatica(2);
            OtraEstatica(7);
            // Variables de tipo función (delegate):
            FuncionQueRecibeInt funRecInt;
            funRecInt = FuncionEstatica;
            funRecInt(200);
            // funRecInt = null; // provocaría una excepción (NullReferenceException)
            funRecInt = OtraEstatica;
            funRecInt(200);
            Console.WriteLine("\n\nOtra libreria, otro módulo, otra función, hace:");
            OtroSistema(FuncionEstatica);
            OtroSistema(OtraEstatica);
            OtroSistema(funRecInt);
        }
        static void OtroSistema(FuncionQueRecibeInt funExt) {
            // Queremos recibir una función como parametro:
            // LlamarFuncionExterna por ejemplo: que reciba un int
            int valor = 3;
            Console.WriteLine("Otro sistema hace sus cosas");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Tardar su tiempo");
            Console.WriteLine("Y llamae a la funcionalidad externa");
            funExt(3);
        }
        static void FuncionEstatica(int x) {
            Console.WriteLine("No necesito un objeto para ser llamada.");
            Console.WriteLine("Param: " + x);
        }
        static void OtraEstatica(int y) {
            Console.WriteLine(y + " - Otra Estática: ");
        }
    }
}
