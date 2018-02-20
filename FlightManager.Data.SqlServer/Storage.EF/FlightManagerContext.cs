using FlightManager.Data.Models;
using FlightManager.Data.SqlServer.Storage.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlightManager.Data.SqlServer.Storage.EF
{
    public class FlightManagerContext : DbContext
    {
        public FlightManagerContext(DbContextOptions<FlightManagerContext> options): base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new AirportMapping(modelBuilder.Entity<Airport>());
            new FlightMapping(modelBuilder.Entity<Flight>());

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }
        }
    }
}
