using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }

        public OrderItem(Product product, double quantity)        {
            Product = product;
            Quantity = quantity;
        }

    }
}
