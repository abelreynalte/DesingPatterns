using System;

namespace Builder1Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            MySandwichBuilder builder = new MySandwichBuilder();
            // ClubSandwichBuilder builder = new ClubSandwichBuilder();
            builder.createSandwich();
            Sandwich sandwich = builder.getSandwich();
            sandwich.display();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
