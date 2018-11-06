using System;

namespace AbstractFactory5
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory abstractFactory = CreditCardFactory.getCreditCardFactory(775);

            CreditCard card = abstractFactory.getCreditCard(CardType.PLATINUM);

            //System.out.println(card.getClass());
            Console.WriteLine(card.GetType());

            abstractFactory = CreditCardFactory.getCreditCardFactory(600);

            CreditCard card2 = abstractFactory.getCreditCard(CardType.GOLD);

            //System.out.println(card2.getClass());
            Console.WriteLine(card2.GetType());
            Console.ReadKey();
        }
    }
}
