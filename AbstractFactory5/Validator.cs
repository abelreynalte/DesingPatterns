using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory5
{
    public interface Validator
    {
        Boolean isValid(CreditCard creditCard);
    }
}
