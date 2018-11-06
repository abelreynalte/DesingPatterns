using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod5
{
    public class BMW: IAuto
    {
        private String name;

        public BMW(String name)
        {
            this.name = name;
        }

        
        public String getName()
        {
            return name;
        }

        
        public void setName(String name)
        {
            this.name = name;
        }

        
        public void turnOn()
        {
            //System.out.println("The " + name + " is on and running.");
            Console.WriteLine("The " + name + " is on and running.");
        }

        
        public void turnOff()
        {
            //System.out.println("The " + name + " is off.");
            Console.WriteLine("The " + name + " is off.");
        }
    }
}
