using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor2
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
