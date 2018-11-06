using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod7
{
    public class ClamPizza: Pizza
    {
        public ClamPizza()
        {
            name = "Clam Pizza";
            dough = "Thin crust";
            sauce = "White garlic sauce";
            toppings.Add("Clams");
            toppings.Add("Grated parmesan cheese");
        }
    }
}
