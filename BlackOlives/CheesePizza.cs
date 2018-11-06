using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public class CheesePizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            //System.out.println("Preparing " + name);
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
