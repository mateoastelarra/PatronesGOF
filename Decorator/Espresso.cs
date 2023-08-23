using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso : DrinkComponent
    {
        public override double Price => 1200;

        public override string Name => "Espresso";
    }
}
