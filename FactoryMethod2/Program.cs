using System;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            String carName = "MiniCopper";//Util.getPropertyValue("config.properties", "DefaultAutoFactoryMethod1");
            AutoFactory factory = new AutoFactory();
            IAuto car = factory.createInstance(carName);
            car.turnOn();
            car.turnOff();

            //Console.WriteLine("Hello World!");
        }
    }
}
