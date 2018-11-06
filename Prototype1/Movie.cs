using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1
{
    public class Movie: Item
    {
        private String runtime;

        public String getRuntime()
        {
            return runtime;
        }

        public void setRuntime(String runtime)
        {
            this.runtime = runtime;
        }
    }
}
