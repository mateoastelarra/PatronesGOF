using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Srategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            List<Weapon> strategies = new List<Weapon>();

            // Can easily add weapons here without changing the rest of the program or classes (just have to add a new weapon class)
            strategies.Add(new Gun());
            strategies.Add(new Rifle());
            strategies.Add(new Bazooka());

            int play = 1;

            while (play != 0)
            {
                string playerDecision;
                Console.WriteLine("1) Change Weapon");
                Console.WriteLine("2)Shoot");
                Console.WriteLine("Press any other key to quit");
                Console.WriteLine("=============");

                playerDecision = Console.ReadLine();

                if (playerDecision == "1")
                {
                    for (int i = 0; i < strategies.Count; i++)
                    {
                        Console.WriteLine($"Weapon {i + 1}: {strategies[i].ToString()}");
                    }
                    Console.WriteLine("=============");
                    int chosenWeapon = int.Parse(Console.ReadLine());
                    try
                    {
                        player.ChangeStrategy(strategies[chosenWeapon - 1]);
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Not valid option");
                    }
                    
                }
                else if (playerDecision == "2")
                {
                    Console.WriteLine(player.Shoot());
                }
                else
                {
                    play = 0;
                }
                Console.WriteLine("=============");
            }
            Console.WriteLine("Thanks for playing.");
            Console.ReadKey();
        }
    }
}
