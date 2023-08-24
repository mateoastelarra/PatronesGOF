using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CompanyInvoker
    {
        List<OrderCommand> orders = new List<OrderCommand>();

        public void TakeOrder(OrderCommand order)
        {
            orders.Add(order);
        }

        public void ProcessOrders()
        {
            foreach (OrderCommand order in orders)
                order.Execute();
            orders.Clear();
        }
    }
}
