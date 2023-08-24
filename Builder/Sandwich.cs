using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Sandwich
    {
        Bread bread;
        Meat meat;
        Vegetable vegetable;
        string type;

        public override string ToString()
        {
            return $"{type}|| Bread: {bread.Description}, Meat: {meat.Description}, Vegetable: {vegetable.Description}";
        }

        public Sandwich(Bread bread, Meat meat, Vegetable vegetable, string type)
        {
            this.bread = bread;
            this.meat = meat;
            this.vegetable = vegetable;
            this.type = type;
        }
    }
}
