using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NewYorkPizzaShop : PizzaShop
    {
        public override Pizza MakePizza()
        {
            return new NewYorkPizza();
        }

        public override Pasta MakePasta()
        {
            return new NewYorkPasta();
        }
    }
}
