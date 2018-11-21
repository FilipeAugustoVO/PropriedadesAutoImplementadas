using System;

namespace PropriedadesAutoImplementadas2
{
    public class Movie
    {
        public string Titulo { get; set; }

        public string Genero { get; set; }

        public override string ToString()
        {
            return Titulo + "\t" + Genero;
        }

    }



    class Program
    {
        static void Main(string[] args)

        {

            Movie m = new Movie();

            m.Titulo = "Em busca da felicidade";

            m.Genero = "Drama";

            Console.WriteLine(m);

            Console.ReadLine();

        }

    }

}

