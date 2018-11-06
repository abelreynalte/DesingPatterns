using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    class ProductB2: AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
