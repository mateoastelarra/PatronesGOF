using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sweetener :PlusDecorator
    {
        public Sweetener(DrinkComponent drink) : base(drink) { }

        public override double Price => drink.Price + 100;

        public override string Name => $"{drink.Name}, Sweetener";
    }
}
