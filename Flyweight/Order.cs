using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Order
    {
        private readonly List<OrderItem> items;

        public Order()
        {
            items = new List<OrderItem>();
        }

        public void AddItem(OrderItem orderItem)
        {
            items.Add(orderItem);
        }
    }
}
