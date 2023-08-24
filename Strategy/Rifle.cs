using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Rifle : Weapon
    {
        public override string Shoot()
        {
            return "Shooting a Rifle. There are many rifles but this one is mine";
        }
    }
}
