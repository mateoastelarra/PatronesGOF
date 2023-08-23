using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TraditionalTea : DrinkComponent
    {
        public override double Price => 800;

        public override string Name => "Traditional Tea";
    }
}
