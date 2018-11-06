using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    public abstract class BMWBase: IAutoMobile
    {
        public abstract String getName();
        
        public void turnOn()
        {
            //System.out.println("The " + getName() + " is on and running.");
            Console.WriteLine("The " + getName() + " is on and running.");
        }
        
        public void turnOff()
        {
            //System.out.println("The " + getName() + " is off.");
            Console.WriteLine("The " + getName() + " is off.");
        }
    }
}
