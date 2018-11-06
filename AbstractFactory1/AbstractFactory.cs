using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
