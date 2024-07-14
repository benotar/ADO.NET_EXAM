using exam2.Entities;
using exam2.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace exam2.Data;

public class RailwayDbContext : DbContext,IRailwayDbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<Journey> Journeys { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    public RailwayDbContext(DbContextOptions<RailwayDbContext> options)
    : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CityConfigurations());
        modelBuilder.ApplyConfiguration(new JourneyConfigurations());
        modelBuilder.ApplyConfiguration(new TicketConfigurations());

        base.OnModelCreating(modelBuilder);
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}

