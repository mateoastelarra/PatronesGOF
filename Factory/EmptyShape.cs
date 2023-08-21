﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class EmptyShape: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Unknown Shape, Unable to draw");
        }
    }
}
