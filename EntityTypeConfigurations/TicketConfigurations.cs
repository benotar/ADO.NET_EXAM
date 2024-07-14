using exam2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam2.EntityTypeConfigurations;

public class TicketConfigurations : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(t => t.Id);
        
        builder.HasOne(t => t.Journey)
            .WithMany(j => j.Tickets)
            .HasForeignKey(j => j.JourneyId);
    }
}