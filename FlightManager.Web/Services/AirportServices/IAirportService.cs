using FlightManager.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Web.Services.AirportServices
{
    public interface IAirportService
    {
        /// <summary>
        /// Retrieves the airports asynchronously
        /// </summary>
        /// <returns>a promise of an enumerable of Airport</returns>
        Task<IEnumerable<Airport>> GetAirportsAsync();
    }
}
