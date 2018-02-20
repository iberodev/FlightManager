using FlightManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManager.Data.SqlServer.Storage.Mapping
{
    public class AirportMapping
    {
        public AirportMapping(EntityTypeBuilder<Airport> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(a => a.Code);
            entityTypeBuilder.Property(a => a.Code)
                .HasMaxLength(3);

            entityTypeBuilder.Property(a => a.Name)
                .HasMaxLength(120);

            entityTypeBuilder.Property(a => a.CreatedOn)
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("GETUTCDATE()")
               .IsRequired(true);

            entityTypeBuilder.Property(a => a.IsDeleted)
                .IsRequired(true)
                .HasDefaultValue(false);

            entityTypeBuilder.Property(a => a.ModifiedOn);
        }
    }
}
