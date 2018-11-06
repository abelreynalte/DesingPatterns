using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public class LuxuryCar: Car
    {
        private String name;

        public LuxuryCar(String name)
        {
            this.name = name;
        }

        public String getCarName()
        {
            return name;
        }

        public String getCarFeatures()
        {
            return "Luxury Car Features ";
        }
    }
}
