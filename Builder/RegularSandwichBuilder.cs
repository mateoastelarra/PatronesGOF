using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RegularSandwichBuilder : SandwichBuilder
    {
        public RegularSandwichBuilder()
        {
            description = "Regular sandwich";
        }
        public override Bread BuildBread()
        {
            return new Brioche();
        }

        public override Meat BuildMeat()
        {
            return new Turkey();
        }

        public override Vegetable BuildVegetable()
        {
            return new TomatoAndLettuce();
        }
    }
}

