using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Approver
    {
        protected Approver next;

        public void AddNext(Approver aprover)
        {
            this.next = aprover;
        }
        public abstract void Aprove(Order order);

    }
}
