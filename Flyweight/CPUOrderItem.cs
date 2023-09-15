using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CPUOrderItem
    {
        private readonly CPUProductFlyweightFactory factory;

        public CPUOrderItem(CPUProductFlyweightFactory factory)
        {
            this.factory = factory;
        }

        public OrderItem Create(CPUSeries series, int quantity)
        {
            Product product = factory.Create(series);

            return new OrderItem(product, quantity);
        }
    }

    public enum CPUSeries
    {
        IntelCoreI9,
        IntelCoreI7,
        Ryzen5,
        Ryzen7
    }
}
