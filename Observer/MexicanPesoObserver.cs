using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class MexicanPesoObserver : Observer
    {
        private double currencyValue = 33;

        public MexicanPesoObserver(Subject subject)
        {
            this.subject = subject;
            subject.AddObserver(this);
        }

        public override void Update()
        {
            Console.WriteLine("Mexican Peso: " + currencyValue * subject.GetState());
        }
    }
}

