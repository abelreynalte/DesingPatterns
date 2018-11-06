using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class ChicagoStyleCheesePizza: Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        void cut()
        {
            //System.out.println("Cutting the pizza into square slices");
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
