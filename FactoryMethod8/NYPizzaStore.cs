using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class NYPizzaStore: PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }
    }
}
