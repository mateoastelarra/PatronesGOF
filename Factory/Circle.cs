using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Circle : IShape
    {
        private float radius;
        
        public float Radius { get => radius; set => radius = value; }
        
        public Circle(float radius = 1)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Circle of radius " + radius);
        }
    }
}
