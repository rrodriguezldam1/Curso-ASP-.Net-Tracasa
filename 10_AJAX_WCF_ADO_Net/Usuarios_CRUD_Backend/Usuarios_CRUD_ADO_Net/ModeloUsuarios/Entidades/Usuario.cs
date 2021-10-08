using System;

namespace ModeloUsuarios
{
    public class Usuario 
    {
        protected string nombre;
        protected int edad;
        protected float altura;

        public Usuario(string nombre, int edad, float altura)
        {
            Nombre = nombre;
            Edad = edad;
            Altura = altura;
        }
        public Usuario()
        {

        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " Edad: " + edad + " Altura: " + altura;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    nombre = "SIN NOMBRE";
                }
            }
        }


        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value > 0 && value < 120 )
                {
                    edad = value;
                }
                else
                {
                    edad = 1;
                }
            }
        }
        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value > 0.1f && value < 3f)
                {
                    altura = value;
                }
                else
                {
                    altura = 1f;
                }
            }
        }
        public override bool Equals(object usuario)
        {
            Usuario u = (Usuario)usuario;
            if (base.Equals(usuario))
                return true;
            else
            {
                return (this.Nombre.Equals(u.Nombre)
                    && this.Edad.Equals(u.Edad)
                    && this.Altura.Equals(u.Altura));
            }
        }
    }
}
