using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sugar : PlusDecorator
    {
        public Sugar(DrinkComponent drink) : base(drink) { }

        public override double Price => drink.Price + 50;

        public override string Name => $"{drink.Name}, Sugar";
    }
}
