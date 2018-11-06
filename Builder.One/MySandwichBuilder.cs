using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Builder.One
{
    public class MySandwichBuilder: SandwichBuilder
    {
        
    public override void prepareBread()
        {
            
            sandwich.breadType = BreadType.White;
            sandwich.isToasted = true;
        }

        
    public override void applyMeatAndCheese()
        {
            sandwich.cheeseType = CheeseType.Cheddar;
            sandwich.meatType = MeatType.Chicken;
        }

        
    public override void applyVegetables()
        {
            sandwich.vegetables = new List<String> { "Tomato", "Onion" };
        }

        
    public override void addCondiments()
        {
            sandwich.hasMayo = false;
            sandwich.hasMustard = true;
        }
    }
}
