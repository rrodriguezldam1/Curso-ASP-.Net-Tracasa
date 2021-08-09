using System;

namespace Ejemplo_Struct_Class
{
    struct ProductoE {
        public string nombre;
        public float precio;

        public ProductoE(string nombre, float precio) {
            this.nombre = nombre;
            this.precio = precio;
        }

        public void MostrarDatos(ProductoE producto) {
            Console.WriteLine("Nombre: " + producto.nombre + "  Precio: " + producto.precio);
        }
    }

    class ProductoC
    {
        public string nombre;
        public float precio;

        public ProductoC(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public void MostrarDatos(ProductoC producto)
        {
            Console.WriteLine("Nombre: " + producto.nombre + "  Precio: " + producto.precio);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProductoE productoe = new ProductoE("Soja", 10.0f);
            ProductoC productoc = new ProductoC("Lana", 8.0f);

            Console.Write("ProductoE fuera y antes: \t");
            productoe.MostrarDatos(productoe);
            ModificarProductoE(productoe);
            Console.Write("\nProductoE fuera y despúes: \t");
            productoe.MostrarDatos(productoe);

            Console.Write("\nProductoC fuera y antes: \t");
            productoc.MostrarDatos(productoc);
            ModificarProductoC(productoc);
            Console.Write("\nProductoC fuera y despúes: \t");
            productoc.MostrarDatos(productoc);

            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Ahora con referencia");
            Console.WriteLine();

            Console.Write("Ref ProductoE fuera y antes: \t");
            productoe.MostrarDatos(productoe);
            ModificarProductoERef(ref productoe);
            Console.Write("\nRef ProductoE fuera y despúes: \t");
            productoe.MostrarDatos(productoe);

            Console.Write("\nRef ProductoC fuera y antes: \t");
            productoc.MostrarDatos(productoc);
            ModificarProductoCRef(ref productoc);
            Console.Write("\nRef ProductoC fuera y despúes: \t");
            productoc.MostrarDatos(productoc);
        }

        static void ModificarProductoE(ProductoE producto) {
            producto.nombre = "Ramen";
            producto.precio = 12.0f;
        }
        
        static void ModificarProductoERef(ref ProductoE producto) {
            producto.nombre = "Ramen";
            producto.precio = 12.0f;
        }


        static void ModificarProductoC(ProductoC producto)
        {
            producto.nombre = "Agua";
            producto.precio = 14.0f;
        }

        static void ModificarProductoCRef(ref ProductoC producto)
        {
            producto.nombre = "Agua";
            producto.precio = 14.0f;
        }
    }
}
