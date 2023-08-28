using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(MotherBoard component)
        {
            Console.WriteLine($"MotherBoard with serial number {component.Serial}");
        }

        public void Visit(Processor component)
        {
            Console.WriteLine($"Processor with serial number {component.Serial}");
        }

        public void Visit(SolidStateDisk component)
        {
            Console.WriteLine($"Solid state disk with serial number {component.Serial}");
        }
    }

    public class ConcreteVisitor2 : IVisitor
    {
        public void Visit(MotherBoard component)
        {
            Console.WriteLine($"Serial number: {component.Serial}");
        }

        public void Visit(Processor component)
        {
            Console.WriteLine($"Serial number {component.Serial}");
        }

        public void Visit(SolidStateDisk component)
        {
            Console.WriteLine($"Serial number {component.Serial}");
        }
    }


}
