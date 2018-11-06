using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory4
{
    public interface PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        Veggies[] createVeggies();
        Pepperoni createPepperoni();
        Clams createClam();
    }
}
