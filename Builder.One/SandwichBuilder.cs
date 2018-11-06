using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.One
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public void setSandwich(Sandwich sandwich)
        {
            this.sandwich = sandwich;
        }

        public Sandwich getSandwich()
        {
            return sandwich;
        }

        public void createNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void prepareBread();

        public abstract void applyMeatAndCheese();

        public abstract void applyVegetables();

        public abstract void addCondiments();
    }
}
