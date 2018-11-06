using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod5
{
    public class BMWFactory: IAutoFactory
    {
        
        public IAuto createAutomobile()
        {
            return new BMW("BMW M5 Cabriolet");
        }
    }
}
