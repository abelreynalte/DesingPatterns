using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory5
{
    public class VisaFactory: CreditCardFactory
    {
        
        public override CreditCard getCreditCard(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.GOLD:

                    return new VisaGoldCreditCard();

                case CardType.PLATINUM:

                    return new VisaBlackCreditCard();

            }

            return null;
        }

        
        public override Validator getValidator(CardType cardType)
        {
            return new VisaValidator();
        }
    }
}
