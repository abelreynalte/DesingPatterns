using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public abstract class Pizza
    {
        public String name;

        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clam;

        public abstract void prepare();

        public void bake()
        {
            //System.out.println("Bake for 25 minutes at 350");
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            //System.out.println("Cutting the pizza into diagonal slices");
            Console.Write("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            //System.out.println("Place pizza in official PizzaStore box");
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public String toString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("---- " + name + " ----\n");
            if (dough != null)
            {
                result.Append(dough);
                result.Append("\n");
            }
            if (sauce != null)
            {
                result.Append(sauce);
                result.Append("\n");
            }
            if (cheese != null)
            {
                result.Append(cheese);
                result.Append("\n");
            }
            if (veggies != null)
            {
                for (int i = 0; i < veggies.Length; i++)
                {
                    result.Append(veggies[i]);
                    if (i < veggies.Length - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (clam != null)
            {
                result.Append(clam);
                result.Append("\n");
            }
            if (pepperoni != null)
            {
                result.Append(pepperoni);
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
