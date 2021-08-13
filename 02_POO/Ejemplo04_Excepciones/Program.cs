using System;

namespace Ejemplo04_Excepciones
{
    class Program
    {
        static void FuncionRecursivaInfinita(int i) {
            if (i < 100) FuncionRecursivaInfinita(50);
        }
        static void Main(string[] args)
        {
            //Excepciones típicas existentes en .Net (y en otros lenguajes)
            //StackOverFlow
            try
            {
                // No queda otra que evitarlo
                FuncionRecursivaInfinita(500);
            }
            catch (Exception ex) 
            {
                Console.Error.WriteLine("Error");
            }
            
            // CAPTURAR ERROR DE MANERA ESPECÍFICA
            try
            {
                Console.WriteLine("Convirtiendo lo inconvertible!");
                int.Parse("ramon");
                Console.WriteLine("Esta línea ni se muestra!");
            }
            catch (FormatException ex) //Cuando ocurre una excepcion en control pasa a los bloques catch
            {
                Console.Error.WriteLine("Error!! ", ex.Message);
            }

            // CAPTURAR ERROR DE MANERA GENÉRICA
            try
            {
                Console.WriteLine("Convirtiendo lo inconvertible!");
                int.Parse("ramon");
                Console.WriteLine("Esta línea ni se muestra!");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error!! ", ex.Message);
            }

            // CAPTURAR ERROR
            try
            {
                Console.WriteLine("Crear un objeto nulo y tratar de usarlo");
                object obj = null;
                Console.WriteLine(obj.ToString());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error!! ", ex.Message);
            }

            // NO CAPTURAR OTRO ERROR
            try
            {
                Console.WriteLine("Crear un objeto nulo y tratar de usarlo");
                object obj = null;
                Console.WriteLine(obj.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.Error.WriteLine("Error!! ", ex.Message);
            }


            try
            {
                FuncionQueDelegaExcepcion();
                // La excepción se propaga siempre hacia arriba hasta
                // que un try catch adecuado la controle
            }
            catch (NullReferenceException ex)
            {
                Console.Error.WriteLine("Error!! ", ex.Message);
            }


        }

        public static void FuncionQueDelegaExcepcion()
        {
            // Si una función lanza una excepción, y no la controlamos aquí
            // podrá o deberá ser controlada en la función que invoca a esta.
            int.Parse("ERROR");
        }
    }
}
