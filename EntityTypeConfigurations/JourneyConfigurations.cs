using exam2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam2.EntityTypeConfigurations;

public class JourneyConfigurations : IEntityTypeConfiguration<Journey>
{
    public void Configure(EntityTypeBuilder<Journey> builder)
    {
        builder.HasKey(j => j.Id);

        builder.HasIndex(j => j.DateDispatch)
            .IsUnique();
        
        builder.HasOne(j => j.CityDeparture)
            .WithMany(c => c.JourneysDeparting)
            .HasForeignKey(c => c.CityDepartureId);

        builder.HasOne(j => j.CityArrival)
            .WithMany(c => c.JourneysArriving)
            .HasForeignKey(c => c.CityArrivalId);
    }
}