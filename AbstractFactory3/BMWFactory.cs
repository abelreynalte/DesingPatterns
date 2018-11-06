using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    public class BMWFactory: IAutoFactory
    {
        public IAutoMobile createSportsCar()
        {
            return new BMWM3();
        }
        
        public IAutoMobile createLuxuryCar()
        {
            return new BMW740i();
        }
        
        public IAutoMobile createEconomyCar()
        {
            return new BMW328i();
        }
    }
}
