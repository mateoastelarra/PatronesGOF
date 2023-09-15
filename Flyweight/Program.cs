using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Program
    {
        static void Main(string[] args)
        {
            CPUProductFlyweightFactory flyweightFactory = new CPUProductFlyweightFactory();
            CPUOrderItem orderItemFactory = new CPUOrderItem(flyweightFactory);

            var seed = new Random();
            int rand = seed.Next(0,4);

            List<Order> orders = new List<Order>();

            for (int i = 0; i < 100; i++)
            {
                Order order = new Order();

                CPUSeries cpuSeries = GetCPUSeries(rand);
                OrderItem cpu = orderItemFactory.Create(cpuSeries, 1);
                order.AddItem(cpu);
                orders.Add(order);

                rand = seed.Next(0, 4);
            }
            
        }


        private static CPUSeries GetCPUSeries(int i)
        {
            return (CPUSeries) i;
        }
    }
}
