using exam2.Entities;
using Microsoft.EntityFrameworkCore;

namespace exam2.Data;

public interface IRailwayDbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<Journey> Journeys { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}