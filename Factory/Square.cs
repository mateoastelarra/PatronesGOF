using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Square : IShape
    {
        private float side;
        
        public float Side { get => side; set => side = value; }
        
        public Square(float side = 1)
        {
            this.side = side;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Square of side " + side);
        }
    }
}

