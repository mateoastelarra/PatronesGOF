using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shape, float parameter = 1)
        {
            if (shape == null)
            {
                return new EmptyShape();
            }
            else if (shape.ToLower() == "square")
            {
                return new Square(parameter);
            }
            else if (shape.ToLower() == "circle")
            {
                return new Circle(parameter);
            }
            return new EmptyShape();
        }
    }
}
