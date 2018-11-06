using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory5
{
    public abstract class CreditCardFactory
    {
        public static CreditCardFactory getCreditCardFactory(int creditScore)
        {

            if (creditScore > 650)
            {
                return new AmexFactory();
            }
            else
            {
                return new VisaFactory();
            }
        }

        public abstract CreditCard getCreditCard(CardType cardType);

        public abstract Validator getValidator(CardType cardType);
    }
}
