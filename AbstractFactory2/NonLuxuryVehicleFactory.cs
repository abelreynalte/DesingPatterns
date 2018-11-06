using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public class NonLuxuryVehicleFactory: VehicleFactory
    {
        public override Car getCar()
        {
            return new NonLuxuryCar("Non Luxury Car");
        }

        public override SUV getSUV()
        {
            return new NonLuxurySUV("Non Luxury SUV");
        }
    }
}
