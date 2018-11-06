using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.One
{
    public class Sandwich
    {
        public BreadType breadType { get; set; }
        public Boolean isToasted { get; set; }
        public CheeseType cheeseType { get; set; }
        public MeatType meatType { get; set; }
        public Boolean hasMustard { get; set; }
        public Boolean hasMayo { get; set; }
        public List<String> vegetables { get; set; }

        //public BreadType getBreadType()
        //{
        //    return breadType;
        //}

        //public void setBreadType(BreadType breadType)
        //{
        //    this.breadType = breadType;
        //}

        //public Boolean isToasted()
        //{
        //    return isToasted;
        //}

        //public void setToasted(Boolean isToasted)
        //{
        //    this.isToasted = isToasted;
        //}

        //public CheeseType getCheeseType()
        //{
        //    return cheeseType;
        //}

        //public void setCheeseType(CheeseType cheeseType)
        //{
        //    this.cheeseType = cheeseType;
        //}

        //public MeatType getMeatType()
        //{
        //    return meatType;
        //}

        //public void setMeatType(MeatType meatType)
        //{
        //    this.meatType = meatType;
        //}

        //public boolean isHasMustard()
        //{
        //    return hasMustard;
        //}

        //public void setHasMustard(boolean hasMustard)
        //{
        //    this.hasMustard = hasMustard;
        //}

        //public boolean isHasMayo()
        //{
        //    return hasMayo;
        //}

        //public void setHasMayo(boolean hasMayo)
        //{
        //    this.hasMayo = hasMayo;
        //}

        //public List<String> getVegetables()
        //{
        //    return vegetables;
        //}

        //public void setVegetables(List<String> vegetables)
        //{
        //    this.vegetables = vegetables;
        //}

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
