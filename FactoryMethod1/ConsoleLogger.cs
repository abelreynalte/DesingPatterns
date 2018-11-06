using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public class ConsoleLogger: Logger
    {
        public void log(String message)
        {
            //System.out.println("Console: " + message);
            Console.WriteLine("Console: " + message);
        }
    }
}
