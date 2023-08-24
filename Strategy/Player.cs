using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Player
    {
        Weapon strategy;

        public void ChangeStrategy(Weapon strategy)
        {
            if (strategy == null) 
                throw new Exception("Undefined Strategy");
            this.strategy = strategy;
        }

        public string Name { get; set; }

        public string Shoot()
        {
            if (strategy == null)
                return "You don´t have a weapon";
            return strategy.Shoot();
        }
    }
}
