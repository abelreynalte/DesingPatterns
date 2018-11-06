using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod6
{
    public abstract class WebSite
    {
        protected List<Page> pages = new List<Page>();

        public List<Page> getPages()
        {
            return pages;
        }

        public WebSite()
        {
            this.createWebsite();
        }

        public abstract void createWebsite();
    }
}
