using System;

namespace AbstractFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Car = "Car";
            String SUV = "SUV";

            String searchResult = null;
            //String vehicleCategory = Util.Util.getPropertyValue("config.properties", "VehicleCategory");
            //String vehicleType = Util.Util.getPropertyValue("config.properties", "VehicleType");
            String vehicleCategory = "Luxury";
            String vehicleType = "Car";

            VehicleFactory vehicleFactory = VehicleFactory.getVehicleFactory(vehicleCategory);

            if (vehicleType.Equals(Car))
            {
                Car car = vehicleFactory.getCar();
                searchResult = "Name: " + car.getCarName() + "\nFeatures: " + car.getCarFeatures();
            }
            else if (vehicleType.Equals(SUV))   
            {
                SUV suv = vehicleFactory.getSUV();
                searchResult = "Name: " + suv.getSUVName() + "\nFeatures: " + suv.getSUVFeatures();
            }
            
            Console.WriteLine(searchResult);
            Console.ReadKey();
        }
    }
}
