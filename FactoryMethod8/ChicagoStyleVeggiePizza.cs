using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod8
{
    public class ChicagoStyleVeggiePizza: Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Eggplant");
        }

        void cut()
        {
            //System.out.println("Cutting the pizza into square slices");
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
