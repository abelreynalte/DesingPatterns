using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Two
{
    public class OrdenacionFactory
    {
        public OrdenacionBuilder getOrdenacionBuilder(String strings)
        {
            OrdenacionBuilder builder = null;
            if (strings.Equals("QS"))
            {
                builder = new OrdenacionQuickSort();
            }
            return builder;
        }
    }
}
