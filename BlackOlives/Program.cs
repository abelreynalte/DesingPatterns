using System;

namespace AbstractFactory4
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            //System.out.println("Ethan ordered a " + pizza + "\n");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("cheese");
            //System.out.println("Joel ordered a " + pizza + "\n");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.orderPizza("clam");
            //System.out.println("Ethan ordered a " + pizza + "\n");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("clam");
            //System.out.println("Joel ordered a " + pizza + "\n");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.orderPizza("pepperoni");
            //System.out.println("Ethan ordered a " + pizza + "\n");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("pepperoni");
            //System.out.println("Joel ordered a " + pizza + "\n");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.orderPizza("veggie");
            //System.out.println("Ethan ordered a " + pizza + "\n");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.orderPizza("veggie");
            //System.out.println("Joel ordered a " + pizza + "\n");
            Console.WriteLine("Joel ordered a " + pizza + "\n");
            Console.ReadKey();
        }
    }
}
