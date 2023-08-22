using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CheckFacade
    {
        private HotelApi hotelApi;
        private FlightApi flightApi;

        public CheckFacade()
        {
            hotelApi = new HotelApi();
            flightApi = new FlightApi();
        }

        public void Search(string departureDate, string arrivalDate, string from, string to)
        {
            flightApi.SearchForFlights(departureDate, arrivalDate, from, to);
            hotelApi.SearchForHotels(departureDate, arrivalDate, to);
        }
    }
}
