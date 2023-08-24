using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            CompanyInvoker company = new CompanyInvoker();
            ProductReceiver product = new ProductReceiver();

            product.Quantity = 0;
            product.ProductName = "Baldurs Gate 3";

            company.TakeOrder(new AddStockCommand(product, 10));
            company.TakeOrder(new ReduceStockCommand(product, 1));
            company.TakeOrder(new ReduceStockCommand(product, 1));
            company.TakeOrder(new ReduceStockCommand(product, 5));
            company.TakeOrder(new AddStockCommand(product, 20));

            company.ProcessOrders();

            Console.WriteLine($"Remaining units of {product.ProductName} : {product.Quantity}");

            Console.ReadKey();
        }
    }
}
