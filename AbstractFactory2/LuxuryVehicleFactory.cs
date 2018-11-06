using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public class LuxuryVehicleFactory: VehicleFactory
    {
        public override Car getCar()
        {
            return new LuxuryCar("Luxury Car");
        }

        public override SUV getSUV()
        {
            return new LuxurySUV("Luxury SUV");
        }
    }
}
