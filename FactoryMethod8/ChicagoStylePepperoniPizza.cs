using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class ChicagoStylePepperoniPizza: Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Eggplant");
            toppings.Add("Sliced Pepperoni");
        }

        void cut()
        {
            //System.out.println("Cutting the pizza into square slices");
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
