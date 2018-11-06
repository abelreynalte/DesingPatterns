﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    class ConcreteFactory2: AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
