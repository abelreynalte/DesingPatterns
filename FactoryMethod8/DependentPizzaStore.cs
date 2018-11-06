using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class DependentPizzaStore
    {
        public Pizza createPizza(String style, String type)
        {
            Pizza pizza = null;
            if (style.Equals("NY"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new NYStyleCheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new NYStyleVeggiePizza();
                }
                else if (type.Equals("clam"))
                {
                    pizza = new NYStyleClamPizza();
                }
                else if (type.Equals("pepperoni"))
                {
                    pizza = new NYStylePepperoniPizza();
                }
            }
            else if (style.Equals("Chicago"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new ChicagoStyleCheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new ChicagoStyleVeggiePizza();
                }
                else if (type.Equals("clam"))
                {
                    pizza = new ChicagoStyleClamPizza();
                }
                else if (type.Equals("pepperoni"))
                {
                    pizza = new ChicagoStylePepperoniPizza();
                }
            }
            else
            {
                //System.out.println("Error: invalid type of pizza");
                Console.WriteLine("Error: invalid type of pizza");
                return null;
            }
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
