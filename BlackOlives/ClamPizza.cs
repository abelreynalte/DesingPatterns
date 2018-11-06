using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public class ClamPizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
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
            clam = ingredientFactory.createClam();
        }
    }
}
