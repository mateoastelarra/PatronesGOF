using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Component
    {
        string serial;

        public Component(string serial)
        {
            this.serial = serial;
        }

        public string Serial { get => serial; }

        public abstract void Accept(IVisitor visitor);
    }
}
