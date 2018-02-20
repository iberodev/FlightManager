using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightManager.Data.SqlServer.Storage.EF
{
    public static class DbInitializer
    {
        public static void Initialize(FlightManagerContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Airports.Any())
            {
                var airports = AirportsData.GetAirports();
                context.AddRange(airports);
                context.SaveChanges();
            }
        }
    }
}
