using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class OrderCommand
    {
        public abstract void Execute();

        protected ProductReceiver product;
        protected double quantity;

        public OrderCommand(ProductReceiver product, double quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
