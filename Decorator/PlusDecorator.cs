using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PlusDecorator : DrinkComponent
    {
        protected DrinkComponent drink;

        public PlusDecorator(DrinkComponent drink)
        {
            this.drink = drink;
        }
    }
}
