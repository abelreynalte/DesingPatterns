using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    public interface IAutoFactory
    {
        IAutoMobile createSportsCar();
        IAutoMobile createLuxuryCar();
        IAutoMobile createEconomyCar();
    }
}
