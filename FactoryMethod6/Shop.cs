using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod6
{
    public class Shop: WebSite
    {
        
        public override void createWebsite()
        {
            pages.Add(new CartPage());
            pages.Add(new ItemPage());
            pages.Add(new SearchPage());
        }
    }
}
