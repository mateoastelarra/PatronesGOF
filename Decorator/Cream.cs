using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cream : PlusDecorator
    {
        public Cream(DrinkComponent drink) : base(drink) { }

        public override double Price => drink.Price + 300;

        public override string Name => $"{drink.Name}, Cream";

    }
}
