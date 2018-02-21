using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightManager.Data.Repositories;
using FlightManager.Web.Model;
using FlightManager.Web.Services.DistanceServices;
using FlightManager.Web.Services.MappingServices;

namespace FlightManager.Web.Services.FlightServices
{
    public class FlightService : IFlightService
    {
        private readonly IFlightsRepository _flightsRepository;
        private readonly IMappingService _mappingService;
        private readonly IDistanceService _distanceService;
        private readonly IFlightInformationService _flightInformationService;

        public FlightService(
            IFlightsRepository flightsRepository,
            IMappingService mappingService,
            IDistanceService distanceService,
            IFlightInformationService flightInformationService)
        {
            _flightsRepository = flightsRepository;
            _mappingService = mappingService;
            _distanceService = distanceService;
            _flightInformationService = flightInformationService;
        }
        
        public async Task AddFlightAsync(FlightNew flight)
        {
            var flightEntity = _mappingService.GetFlight(flight);
            await _flightsRepository.AddFlightAsync(flightEntity);
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            var flights = await _flightsRepository.GetFlightsAsync();
            IList<Flight> flightWebModels = new List<Flight>();
            foreach(var flight in flights)
            {
                var distanceInMetres = _distanceService.GetDistanceInMeters(flight.DepartureAirport.Latitude,
                    flight.DepartureAirport.Longitude, flight.ArrivalAirport.Latitude, flight.ArrivalAirport.Longitude);
                var estimatedFuelConsumption = _flightInformationService.GetEstimatedFuelNeedInMeters(distanceInMetres);
                var flightWebModel =_mappingService.GetFlight(flight, distanceInMetres, estimatedFuelConsumption);
                flightWebModels.Add(flightWebModel);
            }
            return flightWebModels;
        }
    }
}
