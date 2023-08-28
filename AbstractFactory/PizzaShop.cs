using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class PizzaShop
    {
        public abstract Pizza MakePizza();
        public abstract Pasta MakePasta();
    }
}
