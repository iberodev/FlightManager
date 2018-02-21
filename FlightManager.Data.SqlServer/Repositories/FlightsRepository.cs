using FlightManager.Data.Models;
using FlightManager.Data.Repositories;
using FlightManager.Data.SqlServer.Storage.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Data.SqlServer.Repositories
{
    public class FlightsRepository : IFlightsRepository
    {
        private readonly FlightManagerContext _context;

        public FlightsRepository(FlightManagerContext context)
        {
            _context = context;
        }

        public async Task AddFlightAsync(Flight flight)
        {
            await _context.AddAsync(flight);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            var airports = await _context.Flights
                .Where(f => !f.IsDeleted)
                .Include(f => f.DepartureAirport)
                .Include(f => f.ArrivalAirport)
                .ToListAsync();
            return airports;
        }
    }
}
