using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ReduceStockCommand : OrderCommand
    {
        public ReduceStockCommand(ProductReceiver product, Double quantity) : base(product, quantity) { }

        public override void Execute()
        {
            product.ReduceStock(quantity);
        }
    }
}
