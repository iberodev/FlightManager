using FlightManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Data.Repositories
{
    public interface IFlightsRepository
    {
        /// <summary>
        /// Adds a new flight asynchronously
        /// </summary>
        /// <param name="flight">the flight entity</param>
        /// <returns>a promise of void</returns>
        Task AddFlightAsync(Flight flight);

        /// <summary>
        /// Gets persisted flights asynchronously
        /// </summary>
        /// <returns>a promise of enumerable of Flight</returns>
        Task<IEnumerable<Flight>> GetFlightsAsync();
    }
}
