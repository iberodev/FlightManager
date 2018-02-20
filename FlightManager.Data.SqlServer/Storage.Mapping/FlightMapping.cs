using FlightManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManager.Data.SqlServer.Storage.Mapping
{
    public class FlightMapping
    {
        public FlightMapping(EntityTypeBuilder<Flight> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(f => f.Id);

            entityTypeBuilder.Property(a => a.Reference)
                .IsRequired(true)
                .HasMaxLength(6);

            entityTypeBuilder.Property(f => f.DepartureTime)
                .IsRequired(true);

            entityTypeBuilder.Property(f => f.ArrivalTime)
                .IsRequired(true);

            entityTypeBuilder.Property(f => f.CreatedOn)
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("GETUTCDATE()")
               .IsRequired(true);

            entityTypeBuilder.HasOne(f => f.DepartureAirport)
                .WithMany()
                .HasForeignKey(f => f.DepartureAirportCode)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.Property(f => f.DepartureAirportCode)
                .IsRequired(true)
                .HasMaxLength(3);

            entityTypeBuilder.HasOne(f => f.ArrivalAirport)
                .WithMany()
                .HasForeignKey(f => f.ArrivalAirportCode)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.Property(f => f.ArrivalAirportCode)
                .IsRequired(true)
                .HasMaxLength(3);

            entityTypeBuilder.Property(a => a.IsDeleted)
                .IsRequired(true)
                .HasDefaultValue(false);

            entityTypeBuilder.Property(a => a.ModifiedOn);
        }
    }
}
