using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class RenaultPrototype: CarPrototype
    {
        public override CarPrototype Clone()
        {
            return (RenaultPrototype)this.MemberwiseClone();
        }

        public override string ShowCar()
        {
            return $"Renault: {model} Color: {color}";
        }
    }
}
