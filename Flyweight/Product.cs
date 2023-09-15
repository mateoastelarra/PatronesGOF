using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Product
    {
        public string Name { get; }
        public string Description { get; }
        public ProductType type { get; }
        public double Price { get; }

        public Product(string name, string description, ProductType type, double price)
        {
            Name = name;
            Description = description;
            this.type = type;
            Price = price;
        }

    }

    public enum ProductType
    {
        CPU,
        Memory,
        MotherBoard,
        GPU
    }
}
