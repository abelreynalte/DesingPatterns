using System;

namespace FactoryMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = new LoggerFactory();
            Logger logger = factory.getLogger();
            logger.log("A Message to Log");
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
