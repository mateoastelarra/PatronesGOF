using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {

            PizzaShop pizzaShop;
            pizzaShop = new NapolitanPizzaShop();

            Pizza pizza = pizzaShop.MakePizza();
            Pasta pasta = pizzaShop.MakePasta();

            Console.WriteLine(pizza.Name);
            Console.WriteLine(pasta.Name);
            Console.WriteLine("++++++++++++++++++++++++");

            pizzaShop = new NewYorkPizzaShop();
            pasta = pizzaShop.MakePasta();

            pizza = pizzaShop.MakePizza();

            Console.WriteLine(pizza.Name);
            Console.WriteLine(pasta.Name);



        }
    }
}
