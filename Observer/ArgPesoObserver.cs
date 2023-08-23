using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ArgPesoObserver : Observer
    {
        private double currencyValue = 733;

        public ArgPesoObserver(Subject subject)
        {
            this.subject = subject;
            subject.AddObserver(this);
        }

        public override void Update()
        {
            Console.WriteLine("ARG pesos: " + currencyValue * subject.GetState());
        }
    }
}
