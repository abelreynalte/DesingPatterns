using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype3
{
    public class Language: ICloneable
    {
        public String name;

        public Language(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }
        
        public Object Clone()
        {
            return MemberwiseClone();
        }
}
}
