using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory3
{
    public class MiniCooper: IAutoMobile
    {
        private String name;

        public MiniCooper()
        {
            this.name = "Mini Cooper";
        }

        public void addSportPackage()
        {
            name += " S";
        }

        public void addLuxuryPackage()
        {
            name += " with leather upholstery";
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
