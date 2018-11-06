using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod7
{
    public class CheesePizza: Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinara Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }
}
