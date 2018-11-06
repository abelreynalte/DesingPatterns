using System;

namespace FactoryMethod4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfiguracionRegional configuracionRegional = ConfiguracionRegional.getInstancia();
            String region = "EEUU";//Util.getPropertyValue("config.properties", "Region");
            configuracionRegional.setRegion(region);
            FechasFactory fFecha = new FechasFactory();
            FechaGenerica fechaHoy = fFecha.obtenerFecha();
            //System.out.println(region + ": " + fechaHoy.obtenerFecha());
            Console.WriteLine(region + ": " + fechaHoy.obtenerFecha());
            Console.ReadKey();
        }
    }
}
