using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<SandwichBuilder> sandwichBuilders = new List<SandwichBuilder>();

            sandwichBuilders.Add(new LightSandwichBuilder());
            sandwichBuilders.Add(new RegularSandwichBuilder());
            sandwichBuilders.Add(new BigSandwichBuilder());

            int sandwichOption = 1;

            while (sandwichOption != 0)
            {
                Console.WriteLine("Please choose a sandwich (0 to quit)");
                for (int i = 0; i < sandwichBuilders.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {sandwichBuilders[i].description}");
                }
                Console.WriteLine("+++++++++++++++++++");
                try
                {
                    sandwichOption = int.Parse(Console.ReadLine());
                    SandwichBuilder builder = (SandwichBuilder) sandwichBuilders[sandwichOption - 1];
                    Sandwich sandwich = builder.BuildSandwich();
                    Console.WriteLine(sandwich.ToString());
                    Console.WriteLine("+++++++++++++++++++");
                }
                catch
                {
                    Console.WriteLine("please enter a valid option");
                } 
            }
            Console.WriteLine("Thanks for eating at Don Corleone Sandwiches");
            Console.ReadKey();

            
        }
    }
}
