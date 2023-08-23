using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new ArgPesoObserver(subject);
            new MexicanPesoObserver(subject);

            Console.WriteLine("If you want to exchange 10 dollars you will obtain: ");
            subject.SetState(10);
            Console.WriteLine("++++++++++++++++++++++");
            Console.WriteLine("If you want to exchange 20 dollars you will obtain: ");
            subject.SetState(20);
        }
    }
}
