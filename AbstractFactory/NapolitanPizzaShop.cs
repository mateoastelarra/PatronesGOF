using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NapolitanPizzaShop : PizzaShop
    {
        public override Pizza MakePizza()
        {
            return new NapolitanPizza();
        }

        public override Pasta MakePasta()
        {
            return new NapolitanPasta();
        }
    }
}
