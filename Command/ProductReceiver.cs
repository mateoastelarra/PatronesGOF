using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ProductReceiver
    {
        public double Quantity { get; set; }
        public string ProductName { get; set; }

        public void ReduceStock(double quantity)
        {
            Quantity -= quantity;
            Console.WriteLine($"The Stock of {ProductName} was reduced in {quantity} units");
        }

        public void AddStock(double quantity)
        {
            Quantity += quantity;
            Console.WriteLine($"The Stock of {ProductName} was increased in {quantity} units");
        }
    }
}
