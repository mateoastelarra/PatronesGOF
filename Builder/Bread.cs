using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Bread
    {
        protected string description;

        public string Description{ get { return description; } }
    }

    public class Baguete: Bread
    {
        public Baguete()
        {
            description = "Baguete";
        }
    }

    public class Brioche : Bread
    {
        public Brioche()
        {
            description = "Brioche";
        }
    }

    public class MultiGrain : Bread
    {
        public MultiGrain()
        {
            description = "MultiGrain";
        }
    }
}
