using FlightManager.Web.Model;

namespace FlightManager.Web.Services.MappingServices
{
    public class MappingService : IMappingService
    {
        public Airport GetAirport(Data.Models.Airport airport)
        {
            var webModelAirport = new Airport
            {
                Code = airport.Code,
                Name = airport.Name
            };
            return webModelAirport;
        }

        public Flight GetFlight(Data.Models.Flight flight)
        {
            var webModelFlight = new Flight
            {
                Reference = flight.Reference,
                DepartureAirportCode = flight.DepartureAirportCode,
                DepartureTime = flight.DepartureTime,
                ArrivalAirportCode = flight.ArrivalAirportCode,
                ArrivalTime = flight.ArrivalTime
            };
            return webModelFlight;
        }

        public Data.Models.Flight GetFlight(Flight flight)
        {
            var entityFlight = new Data.Models.Flight
            {
                Reference = flight.Reference,
                DepartureAirportCode = flight.DepartureAirportCode,
                DepartureTime = flight.DepartureTime,
                ArrivalAirportCode = flight.ArrivalAirportCode,
                ArrivalTime = flight.ArrivalTime
            };
            return entityFlight;
        }
    }
}
