using System;
using System.Collections.Generic;

namespace Builder1Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich sandwich = new Sandwich(BreadType.Wheat, false, CheeseType.American, MeatType.Turkey, false,
                false, new List<String> { "Tomato", "Onion", "Lettuce" });
            sandwich.display();

            Sandwich2 sandwich2 = new Sandwich2();
            sandwich2.breadType = BreadType.Wheat;
            sandwich2.cheeseType = CheeseType.American;
            sandwich2.meatType = MeatType.Turkey;
            sandwich2.hasMayo  = false;
            sandwich2.isToasted = false;
            sandwich2.vegetables = new List<String> { "Tomato2", "Onion2", "Lettuce2" };
            sandwich2.display();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
