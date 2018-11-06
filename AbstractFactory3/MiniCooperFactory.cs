using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    public class MiniCooperFactory: IAutoFactory
    {
        public IAutoMobile createSportsCar()
        {
            MiniCooper mini = new MiniCooper();
            mini.addSportPackage();
            return mini;
        }
        
        public IAutoMobile createLuxuryCar()
        {
            MiniCooper mini = new MiniCooper();
            mini.addLuxuryPackage();
            return mini;
        }

        public IAutoMobile createEconomyCar()
        {
            return new MiniCooper();
        }
    }
}
