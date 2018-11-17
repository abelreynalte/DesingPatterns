using System;

namespace Flyweight1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arbitrary extrinsic state

            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new

            UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            // Wait for user

            Console.ReadKey();
        }
    }
}
