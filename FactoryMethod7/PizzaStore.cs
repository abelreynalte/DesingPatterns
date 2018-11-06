﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod7
{
    public class PizzaStore
    {
        PizzaFactory factory;

        public PizzaStore(PizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza orderPizza(String type)
        {

            Pizza pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
