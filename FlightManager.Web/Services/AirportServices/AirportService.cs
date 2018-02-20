using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightManager.Data.Repositories;
using FlightManager.Web.Model;
using FlightManager.Web.Services.MappingServices;

namespace FlightManager.Web.Services.AirportServices
{
    public class AirportService : IAirportService
    {
        private readonly IAirportsRepository _airportsRepository;
        private readonly IMappingService _mappingService;

        public AirportService(
            IAirportsRepository airportsRepository,
            IMappingService mappingService)
        {
            _airportsRepository = airportsRepository;
            _mappingService = mappingService;
        }

        public async Task<IEnumerable<Airport>> GetAirportsAsync()
        {
            var airports = await _airportsRepository.GetAirportsAsync();
            var airportWebModels = airports.Select(a => _mappingService.GetAirport(a));
            return airportWebModels;
        }
    }
}
