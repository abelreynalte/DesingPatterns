using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public class NonLuxurySUV: SUV
    {
        private String name;

        public NonLuxurySUV(String sName)
        {
            name = sName;
        }

        public String getSUVName()
        {
            return name;
        }

        public String getSUVFeatures()
        {
            return "Non-Luxury SUV Features ";
        }
    }
}
