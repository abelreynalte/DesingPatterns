using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight1
{
    class UnsharedConcreteFlyweight: Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
              extrinsicstate);
        }
    }
}
