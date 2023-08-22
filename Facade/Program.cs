using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckFacade cliente = new CheckFacade();
            cliente.Search("22/08/2023", "30/08/2023", "Buenos Aires", "Miami");
            cliente.Search("01/09/2023", "11/09/2023", "Santiago", "Nueva York");
        }
    }
}
