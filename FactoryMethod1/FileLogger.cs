using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public class FileLogger: Logger
    {
        public void log(String message)
        {
            //System.out.println("File: " + message);
            Console.WriteLine("File: " + message);
        }
    }
}
