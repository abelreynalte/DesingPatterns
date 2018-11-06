using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor2
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
