using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1Problem1
{
    public class Sandwich
    {
        private BreadType breadType;
        private Boolean isToasted;
        private CheeseType cheeseType;
        private MeatType meatType;
        private Boolean hasMustard;
        private Boolean hasMayo;
        private List<String> vegetables;

        public Sandwich(BreadType breadType, Boolean isToasted, CheeseType cheeseType, MeatType meatType, Boolean hasMustard, Boolean hasMayo, List<String> vegetables)
        {
            this.breadType = breadType;
            this.isToasted = isToasted;
            this.cheeseType = cheeseType;
            this.meatType = meatType;
            this.hasMustard = hasMustard;
            this.hasMayo = hasMayo;
            this.vegetables = vegetables;
        }

        public void display()
        {
            //System.out.format("Sandwich on %s bread%n", breadType);
            Console.WriteLine("Sandwich on %s bread%n", breadType);
            if (isToasted)
            {
                //System.out.format("Toasted%n");
                Console.WriteLine("Toasted%n");
            }
            if (hasMayo)
            {
                //System.out.format("With Mayo%n");
                Console.WriteLine("With Mayo%n");
            }
            if (hasMustard)
            {
                //System.out.format("With Mustard%n");
                Console.WriteLine("With Mustard%n");
            }
            //System.out.format("Meat: %s%n", meatType);
            Console.WriteLine("Meat: %s%n", meatType);
            //System.out.format("Cheese: %s%n", cheeseType);
            Console.WriteLine("Cheese: %s%n", cheeseType);
            //System.out.format("Veggies: %n");
            Console.WriteLine("Veggies: %n");
            foreach (String vegetable in vegetables)
            {
                //System.out.format("   %s%n", vegetable);
                Console.WriteLine("   %s%n", vegetable);
            }
            //System.out.format("******************************%n%n");
            Console.WriteLine("******************************%n%n");
        }
    }
}
