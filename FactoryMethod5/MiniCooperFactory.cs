using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod5
{
    public class MiniCooperFactory: IAutoFactory
    {        
        public IAuto createAutomobile()
        {
            MiniCooper mini = new MiniCooper();
            mini.setName("Mini Cooper S");
            return mini;
        }
    }
}
