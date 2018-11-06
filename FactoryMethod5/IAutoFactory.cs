using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod5
{
    public interface IAutoFactory
    {
        IAuto createAutomobile();
    }
}
