using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class ChicagoStyleClamPizza: Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        void cut()
        {
            //System.out.println("Cutting the pizza into square slices");
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
