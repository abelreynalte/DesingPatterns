using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public class VeggiePizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
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
            veggies = ingredientFactory.createVeggies();
        }
    }
}
