using System;

namespace Builder.Two
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] datos = { "d", "g", "a", "b", "c", "h", "k" };
            OrdenacionFactory factory = new OrdenacionFactory();
            OrdenacionBuilder builder = factory.getOrdenacionBuilder("QS");
            OrdenacionDirector director = new OrdenacionDirector(builder);
            director.build(datos);
            for (int i = 0; i < datos.Length; i++)
            {
                //System.out.println(datos[i]);
                Console.WriteLine(datos[i]);
            }
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
