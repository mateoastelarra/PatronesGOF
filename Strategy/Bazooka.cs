﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Bazooka : Weapon
    {
        public override string Shoot()
        {
            return "KAABOOOOM!!!";
        }
    }
}
