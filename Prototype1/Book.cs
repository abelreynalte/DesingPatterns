using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1
{
    public class Book: Item
    {
        private int numberOfPages;

        public int getNumberOfPages()
        {
            return numberOfPages;
        }

        public void setNumberOfPages(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }
    }
}
