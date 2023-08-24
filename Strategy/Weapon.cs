using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Weapon
    {
        public abstract string Shoot();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
