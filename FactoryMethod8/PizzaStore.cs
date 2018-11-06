using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public abstract class PizzaStore
    {
        public abstract Pizza createPizza(String item);

        public Pizza orderPizza(String type)
        {
            Pizza pizza = createPizza(type);
            //System.out.println("--- Making a " + pizza.getName() + " ---");
            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
