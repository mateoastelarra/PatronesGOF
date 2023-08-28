using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            Switch sw = new Switch();

            sw.Press();
            sw.Press();
            sw.Press();
            sw.Press();
            sw.Press();

            Console.ReadKey();

        }
    }
}
