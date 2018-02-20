using System;

namespace FlightManager.Web.Model
{
    public class Flight
    {
        public string Reference { get; set; }
        public string DepartureAirportCode { get; set; }
        public DateTime DepartureTime { get; set; }
        public string ArrivalAirportCode { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
