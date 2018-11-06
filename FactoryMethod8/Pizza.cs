using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public abstract class Pizza
    {
        public String name;
        public String dough;
        public String sauce;
        public List<String> toppings = new List<String>();

        public void prepare()
        {
            //System.out.println("Preparing " + name);
            Console.WriteLine("Preparing " + name);
            //System.out.println("Tossing dough...");
            Console.WriteLine("Tossing dough...");
            //System.out.println("Adding sauce...");
            Console.WriteLine("Adding sauce...");
            //System.out.println("Adding toppings: ");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                //System.out.println("   " + toppings.get(i));
                Console.WriteLine("   " + toppings[i]);
            }
        }

        public void bake()
        {
            //System.out.println("Bake for 25 minutes at 350");
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            //System.out.println("Cutting the pizza into diagonal slices");
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            //System.out.println("Place pizza in official PizzaStore box");
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public String getName()
        {
            return name;
        }

        public String toString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + name + " ----\n");
            display.Append(dough + "\n");
            display.Append(sauce + "\n");
            for (int i = 0; i < toppings.Count; i++)
            {
                display.Append((String)toppings[i] + "\n");
            }
            return display.ToString();
        }
    }
}
