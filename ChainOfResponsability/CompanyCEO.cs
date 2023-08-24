using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class CompanyCEO : Approver
    {
        public override void Aprove(Order order)
        {
            Console.WriteLine("The companie´s CEO has approved the order");
        }
    }
}
