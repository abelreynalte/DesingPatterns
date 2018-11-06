using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod6
{
    public class WebsiteFactory
    {
        public static WebSite getWebsite(WebsiteType siteType)
        {
            switch (siteType)
            {
                case WebsiteType.BLOG:
                    {
                        return new Blog();
                    }

                case WebsiteType.SHOP:
                    {
                        return new Shop();
                    }

                default:
                    {
                        return null;
                    }
            }
        }
    }
}
