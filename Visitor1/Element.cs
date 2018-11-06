using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
