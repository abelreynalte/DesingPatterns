using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory5
{
    public class AmexGoldValidator: Validator
    {
        
        public Boolean isValid(CreditCard creditCard)
        {

            return false;
        }
    }
}
