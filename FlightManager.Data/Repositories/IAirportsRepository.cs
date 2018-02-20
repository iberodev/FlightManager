using FlightManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Data.Repositories
{
    public interface IAirportsRepository
    {
        /// <summary>
        /// Retrieves persisted airports asynchronously
        /// </summary>
        /// <returns>an enumerable of airports</returns>
        Task<IEnumerable<Airport>> GetAirportsAsync();
    }
}
