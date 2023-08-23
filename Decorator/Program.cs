using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            DrinkComponent coffee = new Coffee();

            Console.WriteLine($"Drink : {coffee.Name} ||| Price {coffee.Price}");

            coffee = new Milk(coffee);

            Console.WriteLine($"Drink : {coffee.Name} ||| Price {coffee.Price}");

            coffee = new Sugar(coffee);

            Console.WriteLine($"Drink : {coffee.Name} ||| Price {coffee.Price}");

            Console.ReadKey();
        }
    }
}