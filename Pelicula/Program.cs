using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;

        //Constructores
        public Pelicula()
        {
        }

        public Pelicula(string titulo, Int16 Año)
        {
            this.titulo = titulo;
            this.año = Año;
        }
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades
        string Nombre {get; set;}
        Int16 Año{get; set;}

        //Constructores
        public AsignarActores(string nombre, Int16 año)
        {
            this.Nombre = Nombre;
            this.año = Año;
        }

        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Titanic");
            p1.SetAño(1997);

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Ben-Hur");
            p2.SetAño(1959);

            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
        }
    }
}
