using System;

namespace Prototype1
{
    class Program
    {
        static void Main(string[] args)
        {
            Registry registry = new Registry();
            Movie movie = (Movie)registry.createItem("Movie");
            movie.setTitle("Creational Patterns in Java");
            //System.out.println(movie);
            Console.WriteLine(movie);
            //System.out.println(movie.getRuntime());
            Console.WriteLine(movie.getRuntime());
            //System.out.println(movie.getTitle());
            Console.WriteLine(movie.getTitle());
            //System.out.println(movie.getPrice());
            Console.WriteLine(movie.getPrice());

            //System.out.println("*******************************************");
            Console.WriteLine("*******************************************");

            Movie anotherMovie = (Movie)registry.createItem("Movie");
            anotherMovie.setTitle("Gang of Four");
            //System.out.println(anotherMovie);
            Console.WriteLine(anotherMovie);
            //System.out.println(anotherMovie.getRuntime());
            Console.WriteLine(anotherMovie.getRuntime());
            //System.out.println(anotherMovie.getTitle());
            Console.WriteLine(anotherMovie.getTitle());
            //System.out.println(anotherMovie.getPrice());
            Console.WriteLine(anotherMovie.getPrice());
            Console.ReadKey();
        }
    }
}
