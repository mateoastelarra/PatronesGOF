using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HotelApi
    {
        public void SearchForHotels(string checkInDate, string checkOutDate, string city)
        {
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine($"Hotels found in {city}:");
            Console.WriteLine($"CHECK-IN: {checkInDate}");
            Console.WriteLine($"CHECK-OUT: {checkOutDate}");
            Console.WriteLine($"Hotel A");
            Console.WriteLine($"Hotel B");
            Console.WriteLine("++++++++++++++++++++");
        }
    }
}
