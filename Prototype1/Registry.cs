using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1
{
    public class Registry
    {
        private Dictionary<String, Item> items = new Dictionary<String, Item>();

        public Registry()
        {
            loadItems();
        }

        public Item createItem(String type)
        {
            Item item = null;
            try
            {
                item = (Item)(items[type]).Clone();
            }
            catch (NotSupportedException e)
            {
                e.ToString();
            }
            return item;
        }

        private void loadItems()
        {
            Movie movie = new Movie();
            movie.setTitle("Basic Movie");
            movie.setPrice(24.99);
            movie.setRuntime("2 hours");
            items["Movie"] = movie;

            Book book = new Book();
            book.setNumberOfPages(335);
            book.setPrice(19.99);
            book.setTitle("Basic Book");
            items["Book"] = book;
        }
    }
}
