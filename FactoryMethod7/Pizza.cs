using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod7
{
    public abstract class Pizza
    {
        public String name = null;
        public String dough;
        public String sauce;
        public List<String> toppings = new List<String>();

        public String getName()
        {
            return name;
        }

        public void prepare()
        {
            //System.out.println("Preparing " + name);
            Console.WriteLine("Preparing " + name);
        }

        public void bake()
        {
            //System.out.println("Baking " + name);
            Console.WriteLine("Baking " + name);
        }

        public void cut()
        {
            //System.out.println("Cutting " + name);
            Console.WriteLine("Cutting " + name);
        }

        public void box()
        {
            //System.out.println("Boxing " + name);
            Console.WriteLine("Boxing " + name);
        }

        public String toString()
        {
            // code to display pizza name and ingredients
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
