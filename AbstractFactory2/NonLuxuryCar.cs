using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public class NonLuxuryCar: Car
    {
        private String name;

        public NonLuxuryCar(String cName)
        {
            name = cName;
        }

        public String getCarName()
        {
            return name;
        }

        public String getCarFeatures()
        {
            return "Non-Luxury Car Features ";
        }
    }
}
