using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    public class MiniCopper: IAuto
    {        
        public String getName()
        {
            return "Mini Cooper";
        }
        
        public void turnOn()
        {
            //System.out.println("The Mini Cooper is on! 1.6 Liters of brutal force is churning.");
            Console.WriteLine("The Mini Cooper is on! 1.6 Liters of brutal force is churning.");
        }
        
        public void turnOff()
        {
            //System.out.println("The Mini Cooper is has turned off.");
            Console.WriteLine("The Mini Cooper is has turned off.");
        }
    }
}
