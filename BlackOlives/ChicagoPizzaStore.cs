using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public class ChicagoPizzaStore: PizzaStore
    {
        protected override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {

                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");

            }
            else if (item.Equals("veggie"))
            {

                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("Chicago Style Veggie Pizza");

            }
            else if (item.Equals("clam"))
            {

                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza");

            }
            else if (item.Equals("pepperoni"))
            {

                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("Chicago Style Pepperoni Pizza");

            }
            return pizza;
        }
    }
}
