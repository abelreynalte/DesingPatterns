using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor2
{
    class Clerk: Employee
    {
        // Constructor

        public Clerk()
          : base("Hank", 25000.0, 14)
        {
        }
    }
}
