using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Meat
    {
        protected string description;

        public string Description { get { return description; } }
    }

    public class Turkey : Meat
    {
        public Turkey()
        {
            description = "Turkey";
        }
    }

    public class Chicken : Meat
    {
        public Chicken()
        {
            description = "Chicken";
        }
    }

    public class Pork : Meat
    {
        public Pork()
        {
            description = "Pork";
        }
    }
}
