using System;

namespace FactoryMethod7
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.out.println("");
            Console.WriteLine("");
            PizzaFactory factory = new PizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.orderPizza("cheese");
            //System.out.println("We ordered a " + pizza.getName() + "\n");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");
            //System.out.println(pizza.toString());
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");

            //System.out.println("*****************************************" + "\n");
            Console.WriteLine("*****************************************" + "\n");

            pizza = store.orderPizza("veggie");
            //System.out.println("We ordered a " + pizza.getName() + "\n");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");
            //System.out.println(pizza.toString());
            Console.WriteLine(pizza.toString());
            Console.ReadKey();
        }
    }
}
