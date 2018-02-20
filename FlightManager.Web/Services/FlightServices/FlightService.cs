using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightManager.Data.Repositories;
using FlightManager.Web.Model;
using FlightManager.Web.Services.MappingServices;

namespace FlightManager.Web.Services.FlightServices
{
    public class FlightService : IFlightService
    {
        private readonly IFlightsRepository _flightsRepository;
        private readonly IMappingService _mappingService;

        public FlightService(
            IFlightsRepository flightsRepository,
            IMappingService mappingService)
        {
            _flightsRepository = flightsRepository;
            _mappingService = mappingService;
        }
        
        public async Task AddFlightAsync(Flight flight)
        {
            var flightEntity = _mappingService.GetFlight(flight);
            await _flightsRepository.AddFlightAsync(flightEntity);
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            var flights = await _flightsRepository.GetFlightsAsync();
            var flightWebModels = flights.Select(f => _mappingService.GetFlight(f));
            return flightWebModels;
        }
    }
}
