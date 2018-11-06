using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod7
{
    public class PizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}
