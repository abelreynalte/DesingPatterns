using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public class NYPizzaStore: PizzaStore
    {
        protected override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {

                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");

            }
            else if (item.Equals("veggie"))
            {

                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");

            }
            else if (item.Equals("clam"))
            {

                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");

            }
            else if (item.Equals("pepperoni"))
            {

                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("New York Style Pepperoni Pizza");

            }
            return pizza;
        }
    }
}
