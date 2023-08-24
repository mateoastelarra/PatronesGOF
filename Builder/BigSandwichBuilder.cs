using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BigSandwichBuilder : SandwichBuilder
    {
        public BigSandwichBuilder()
        {
            description = "Big sandwich";
        }
        public override Bread BuildBread()
        {
            return new Baguete();
        }

        public override Meat BuildMeat()
        {
            return new Pork();
        }

        public override Vegetable BuildVegetable()
        {
            return new GrilledOnions();
        }
    }
}
