using System;
using System.Reflection;

namespace FactoryMethod5
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autoFactory = loadFactory();
            IAuto car = autoFactory.createAutomobile();
            car.turnOn();
            car.turnOff();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        private static IAutoFactory loadFactory()
        {
            IAutoFactory autoFactory = null;
            //String factoryName = Util.getPropertyValue("config.properties", "DefaultAutoFactoryMethod");
            string assemblyPath = Environment.CurrentDirectory + "\\FactoryMethod5.dll";
            Assembly assembly;
            assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType("FactoryMethod5.BMWFactory");
            try {
                autoFactory = (IAutoFactory)System.Activator.CreateInstance(type); //Class.forName(factoryName).newInstance();
            } catch(Exception ex) {
        	    throw ex;
            }
            return autoFactory;
        }
    }
}
