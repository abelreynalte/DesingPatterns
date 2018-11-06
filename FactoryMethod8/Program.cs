using System;

namespace FactoryMethod8
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            //System.out.println("Ethan ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("cheese");
            //System.out.println("Joel ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("clam");
            //System.out.println("Ethan ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("clam");
            //System.out.println("Joel ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("pepperoni");
            //System.out.println("Ethan ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("pepperoni");
            //System.out.println("Joel ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("veggie");
            //System.out.println("Ethan ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("veggie");
            //System.out.println("Joel ordered a " + pizza.getName() + "\n");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");
            Console.ReadKey();
        }
    }
}
