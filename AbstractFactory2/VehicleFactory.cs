using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public abstract class VehicleFactory
    {
        public static String LUXURY_VEHICLE = "Luxury";
	    public static String NON_LUXURY_VEHICLE = "Non-Luxury";
	
	    public abstract Car getCar();
        public abstract SUV getSUV();

        public static VehicleFactory getVehicleFactory(String type)
        {

            if (type.Equals(VehicleFactory.LUXURY_VEHICLE))
            {
                return new LuxuryVehicleFactory();
            }

            if (type.Equals(VehicleFactory.NON_LUXURY_VEHICLE))
            {
                return new NonLuxuryVehicleFactory();
            }

            return new LuxuryVehicleFactory();
        }
    }
}
