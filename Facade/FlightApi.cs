using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FlightApi
    {
        public void SearchForFlights(string departureDate, string arrivalDate, string from, string to)
        {
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine($"Searching for flights from {from} to {to}");
            Console.WriteLine($"Departure Date: {departureDate}, Arrival Date: {arrivalDate}");
            Console.WriteLine("++++++++++++++++++++");
        }
    }
}
