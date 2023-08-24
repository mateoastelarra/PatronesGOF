using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalesMan salesMan = new SalesMan();
            StoreManager storeManager = new StoreManager();
            CompanyCEO companyCeo = new CompanyCEO();

            salesMan.AddNext(storeManager);
            storeManager.AddNext(companyCeo);

            Order order = new Order();
            double price = 1;
            
            while (price != 0)
            {
                Console.WriteLine("Please write the price of the order (or 0 to quit)");
                try 
                {
                    price = double.Parse(Console.ReadLine());
                    order.Price = price;
                    salesMan.Aprove(order);
                }
                catch
                {
                    Console.WriteLine("Not a valid price.");
                }
                Console.WriteLine("+++++++++++++++++++++++");
                
            }
            Console.ReadKey();

        }
    }
}
