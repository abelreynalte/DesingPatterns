using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.One
{
    public class SandwichDirector
    {
        private SandwichBuilder builder;

        public SandwichDirector(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void buildSandwich()
        {
            builder.createNewSandwich();
            builder.prepareBread();
            builder.applyMeatAndCheese();
            builder.applyVegetables();
            builder.addCondiments();
        }

        public Sandwich getSandwhich()
        {
            return builder.getSandwich();
        }
    }
}
