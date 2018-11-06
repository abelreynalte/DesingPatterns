using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    public class ConcreteElementB: Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
    }
}
