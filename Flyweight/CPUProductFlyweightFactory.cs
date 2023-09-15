using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CPUProductFlyweightFactory
    {
        private readonly Dictionary<CPUSeries, Product> cpuSeriesToProduct;

        public CPUProductFlyweightFactory()
        {
            cpuSeriesToProduct = new Dictionary<CPUSeries, Product>();
        }

        public Product Create(CPUSeries series)
        {
            if (!cpuSeriesToProduct.ContainsKey(series))
            {
                switch(series)
                {
                    case CPUSeries.IntelCoreI9:
                        cpuSeriesToProduct.Add(series, new Product("Intel Core i9", "powerful intel CPU", ProductType.CPU, 500));
                        break;
                    case CPUSeries.IntelCoreI7:
                        cpuSeriesToProduct.Add(series, new Product("Intel Core i7", "intel CPU", ProductType.CPU, 300));
                        break;
                    case CPUSeries.Ryzen7:
                        cpuSeriesToProduct.Add(series, new Product("Ryzen 7", "powerful AMD CPU", ProductType.CPU, 300));
                        break;
                    case CPUSeries.Ryzen5:
                        cpuSeriesToProduct.Add(series, new Product("Ryzen 5", "AMD CPU", ProductType.CPU, 200));
                        break;
                    default:
                        throw new Exception("Unknown CPU series");
                }
            }

            return cpuSeriesToProduct[series];
        }
    }
}
