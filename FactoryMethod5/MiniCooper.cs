using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod5
{
    public class MiniCooper: IAuto
    {
        private String name;

        
        public String getName()
        {
            return "Mini Cooper";
        }

        
        public void setName(String name)
        {
            this.name = name;
        }

        
        public void turnOn()
        {
            //System.out.println("The " + name + " is on! 1.6 Liters of brutal force is churning.");
            Console.WriteLine("The " + name + " is on! 1.6 Liters of brutal force is churning.");
        }

        
        public void turnOff()
        {
            //System.out.println("The " + name + " is has turned off.");
            Console.WriteLine("The " + name + " is has turned off.");
        }
    }
}
