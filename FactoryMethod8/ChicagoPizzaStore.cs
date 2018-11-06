using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class ChicagoPizzaStore: PizzaStore
    {
        public override Pizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}
