using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class FiatPrototype : CarPrototype
    {
        public override CarPrototype Clone()
        {
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string ShowCar()
        {
            return $"Fiat: {model} Color: {color}";
        }
    }
}
