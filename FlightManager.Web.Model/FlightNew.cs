using System;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.Web.Model
{
    public class FlightNew
    {
        [Required]
        public string Reference { get; set; }

        [Required]
        public string DepartureAirportCode { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public string ArrivalAirportCode { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }
    }
}
