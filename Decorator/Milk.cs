using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : PlusDecorator
    {
        public Milk(DrinkComponent drink) : base(drink) { }

        public override double Price => drink.Price + 200;

        public override string Name => $"{drink.Name}, Milk";
    }
}
