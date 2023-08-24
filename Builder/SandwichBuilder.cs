using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class SandwichBuilder
    {
        public string description;

        public abstract Bread BuildBread();
        public abstract Meat BuildMeat();
        public abstract Vegetable BuildVegetable();

        public override string ToString()
        {
            return description;
        }

        public Sandwich BuildSandwich()
        {
            Bread bread = BuildBread();
            Meat meat = BuildMeat();
            Vegetable vegetable = BuildVegetable();

            return new Sandwich(bread, meat, vegetable, description);
        }
    }
}
