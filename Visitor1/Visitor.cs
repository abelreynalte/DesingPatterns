using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(
              ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
          ConcreteElementB concreteElementB);
    }
}
