using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ChainOfResponsability
{
    public class StoreManager : Approver
    {

        public override void Aprove(Order order)
        {
            if (order.Price < 100000)
            {
                Console.WriteLine("The store manager approved the order");
            }
            else
            {
                next.Aprove(order);
            }

        }
    }
}

