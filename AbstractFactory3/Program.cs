using System;
using System.Reflection;

namespace AbstractFactory3
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = new BMWFactory(); //loadFactory();

            printHeader("SPORTS CAR");
            IAutoMobile car = factory.createSportsCar();
            car.turnOn();
            car.turnOff();

            printHeader("LUXURY CAR");
            car = factory.createLuxuryCar();
            car.turnOn();
            car.turnOff();

            printHeader("ECONOMY CAR");
            car = factory.createEconomyCar();
            car.turnOn();
            car.turnOff();

            Console.ReadKey();
        }        
	
	    public static void printHeader(String title)
        {
            //System.out.format("++++++++++++++++ %s ++++++++++++++++++\n", title);
            Console.WriteLine("++++++++++++++++ %s ++++++++++++++++++\n", title);
        }
    }
}
