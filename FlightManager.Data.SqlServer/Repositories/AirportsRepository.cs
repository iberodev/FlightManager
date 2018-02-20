using FlightManager.Data.Models;
using FlightManager.Data.Repositories;
using FlightManager.Data.SqlServer.Storage.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Data.SqlServer.Repositories
{
    public class AirportsRepository : IAirportsRepository
    {
        private readonly FlightManagerContext _context;

        public AirportsRepository(FlightManagerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Airport>> GetAirportsAsync()
        {
            var airports = await _context.Airports
                .Where(a => !a.IsDeleted)
                .ToListAsync();
            return airports;
        }
    }
}
