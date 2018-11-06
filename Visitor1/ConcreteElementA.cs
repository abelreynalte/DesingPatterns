using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    public class ConcreteElementA: Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
        }
    }
}
