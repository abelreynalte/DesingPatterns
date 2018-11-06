using System;

namespace FactoryMethod6
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSite site = WebsiteFactory.getWebsite(WebsiteType.BLOG);

            //System.out.println("Blog Pages: " + site.getPages());
            Console.WriteLine("Blog Pages: " + site.getPages());

            site = WebsiteFactory.getWebsite(WebsiteType.SHOP);

            //System.out.println("Shop Pages: " + site.getPages());
            Console.WriteLine("Shop Pages: " + site.getPages());
            Console.ReadKey();
        }
    }
}
