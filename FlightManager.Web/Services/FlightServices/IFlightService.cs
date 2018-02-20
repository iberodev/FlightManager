using FlightManager.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Web.Services.FlightServices
{
    public interface IFlightService
    {
        /// <summary>
        /// Retrieves all the existing flights asynchronously
        /// </summary>
        /// <returns>an enumerable of flights</returns>
        Task<IEnumerable<Flight>> GetFlightsAsync();


        /// <summary>
        /// Adds a new flight asynchronously
        /// </summary>
        /// <param name="flight">the new flight</param>
        /// <returns>a promise of void</returns>
        Task AddFlightAsync(Flight flight);
    }
}
