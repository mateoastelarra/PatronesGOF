using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Coffee: DrinkComponent
    {
        public override double Price => 1000;

        public override string Name => "Coffee";
    }
}
