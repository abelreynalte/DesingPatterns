using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod5
{
    public interface IAuto
    {
        String getName();
        void setName(String name);
        void turnOn();
        void turnOff();
    }
}
