using System;

namespace Builder.One
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichDirector sandwichDirector = new SandwichDirector(new MySandwichBuilder());
            sandwichDirector.buildSandwich();
            Sandwich sandwich1 = sandwichDirector.getSandwhich();
            sandwich1.display();

            SandwichDirector sandwichDirector2 = new SandwichDirector(new ClubSandwichBuilder());
            sandwichDirector2.buildSandwich();
            Sandwich sandwich2 = sandwichDirector2.getSandwhich();
            sandwich2.display();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
