using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class SalesMan : Approver
    {

        public override void Aprove(Order order)
        {
            if (order.Price < 10000)
            {
                Console.WriteLine("The sales man approved the order");
            }
            else
            {
                next.Aprove(order);
            }

        }
    }
}
