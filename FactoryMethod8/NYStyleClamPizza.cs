using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class NYStyleClamPizza: Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams from Long Island Sound");
        }
    }
}
