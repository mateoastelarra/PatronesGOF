using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new ConcreteVisitor();
            IVisitor visitor2 = new ConcreteVisitor2();

            Component processor = new Processor("2374k1-pr");
            Component motherboard = new MotherBoard("904653l8-mb");
            Component solidStateDisk = new SolidStateDisk("34578u2-sd");

            processor.Accept(visitor);
            motherboard.Accept(visitor);
            solidStateDisk.Accept(visitor);

            processor.Accept(visitor2);
            motherboard.Accept(visitor2);
            solidStateDisk.Accept(visitor2);

            Console.ReadKey();

        }
    }
}
