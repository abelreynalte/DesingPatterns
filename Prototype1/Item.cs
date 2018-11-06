using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1
{
    public abstract class Item: ICloneable
    {
        private String title;
        private double price;
        private String url;

        
        public Object Clone()
        {
            return MemberwiseClone(); // MemberwiseClone C#
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public String getUrl()
        {
            return url;
        }

        public void setUrl(String url)
        {
            this.url = url;
        }
    }
}
