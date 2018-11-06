using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.One
{
    public class ClubSandwichBuilder: SandwichBuilder
    {
        
        public override void prepareBread()
        {
            sandwich.breadType = BreadType.White;
            sandwich.isToasted = true;
        }

        
        public override void applyMeatAndCheese()
        {
            sandwich.cheeseType = CheeseType.Swiss;
            sandwich.meatType = MeatType.Turkey;
        }

        
        public override void applyVegetables()
        {
            sandwich.vegetables = new List<String> { "Tomato", "Onion", "Lettuce" };
        }

        
        public override void addCondiments()
        {
            sandwich.hasMayo = true;
            sandwich.hasMustard = true;
        }
    }
}
