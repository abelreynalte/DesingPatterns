using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory2
{
    public class LuxurySUV: SUV
    {
        private String name;

        public LuxurySUV(String name)
        {
            this.name = name;
        }

        public String getSUVName()
        {
            return name;
        }

        public String getSUVFeatures()
        {
            return "Luxury SUV Features ";
        }
    }
}
