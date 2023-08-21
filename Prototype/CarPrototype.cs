using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class CarPrototype
    {
        protected string color;
        protected string model;

        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }

        public abstract CarPrototype Clone();

        public abstract string ShowCar();
    }
}
