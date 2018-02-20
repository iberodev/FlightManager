using System;

namespace FlightManager.Data.Models
{
    public class Flight : IModel
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public AirplaneType AirplaneType { get; set; }
        public Airport DepartureAirport { get; set; }
        public string DepartureAirportCode { get; set; }
        public DateTime DepartureTime { get; set; }
        public string ArrivalAirportCode { get; set; }
        public Airport ArrivalAirport { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
