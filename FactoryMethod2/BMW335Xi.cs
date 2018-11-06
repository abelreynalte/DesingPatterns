using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    public class BMW335Xi: IAuto
    {
        
        public String getName()
        {
            return "BMW 335Xi";
        }

        
        public void turnOn()
        {
            //System.out.println("The BMW 335Xi is on and running.");
            Console.WriteLine("The BMW 335Xi is on and running.");
        }
        
        public void turnOff()
        {
            //System.out.println("The BMW 335Xi is off.");
            Console.WriteLine("The BMW 335Xi is off.");
        }
    }
}
