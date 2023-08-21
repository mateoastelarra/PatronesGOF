using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("Square", 2);
            shape1.Draw();
            
            IShape shape2 = shapeFactory.GetShape("Circle", 4);
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("Hello World");
            shape3.Draw();
        }
    }
}