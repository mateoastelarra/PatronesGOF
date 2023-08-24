using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LightSandwichBuilder : SandwichBuilder
    {
        public LightSandwichBuilder()
        {
            description = "Light sandwich";
        }
        public override Bread BuildBread()
        {
            return new MultiGrain();
        }

        public override Meat BuildMeat()
        {
            return new Chicken();
        }

        public override Vegetable BuildVegetable()
        {
            return new BoiledCarrots();
        }
    }
}

