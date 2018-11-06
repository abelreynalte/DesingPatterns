using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory5
{
    public class AmexFactory: CreditCardFactory
    {
        public override CreditCard getCreditCard(CardType cardType)
        {

            switch (cardType)
            {
                case CardType.GOLD:
                    return new AmexGoldCreditCard();

                case CardType.PLATINUM:
                    return new AmexPlatinumCreditCard();

                default:
                    break;
            }

            return null;
        }
        
        public override Validator getValidator(CardType cardType)
        {

            switch (cardType)
            {
                case CardType.GOLD:

                    return new AmexGoldValidator();

                case CardType.PLATINUM:

                    return new AmexPlatinumValidator();

            }

            return null;
        }
    }
}
