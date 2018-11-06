using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1Problem2
{
    public class MySandwichBuilder
    {
        Sandwich sandwich;

        public Sandwich getSandwich()
        {
            return sandwich;
        }

        public void createSandwich()
        {
            sandwich = new Sandwich();
            this.prepareBread();
            this.applyMeatAndCheese();
            this.addCondiments();
            this.applyVegetables();
        }

        public void prepareBread()
        {
            sandwich.breadType = BreadType.White;
            sandwich.isToasted = true;
        }

        public void applyMeatAndCheese()
        {
            sandwich.cheeseType = CheeseType.Cheddar;
            sandwich.meatType = MeatType.Chicken;
        }

        public void applyVegetables()
        {
            sandwich.vegetables = new List<String> { "Tomato", "Onion" };
        }

        public void addCondiments()
        {
            sandwich.hasMayo = false;
            sandwich.hasMustard = true;
        }
    }
}
