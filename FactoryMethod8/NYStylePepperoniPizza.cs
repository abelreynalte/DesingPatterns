using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class NYStylePepperoniPizza: Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Garlic");
            toppings.Add("Onion");
            toppings.Add("Mushrooms");
            toppings.Add("Red Pepper");
        }
    }
}
