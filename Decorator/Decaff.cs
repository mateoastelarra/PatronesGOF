using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Decaff : DrinkComponent
    {
        public override double Price => 1500;

        public override string Name => "Decaff";
    }
}
