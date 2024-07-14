using exam2.Data;
using exam2.Entities;
using exam2.Helper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace exam2.SQRS.Commands;

public record CreateTicketsCommand(int JourneyId) : IRequest<bool>;

public class CreateTicketsCommandHandler : IRequestHandler<CreateTicketsCommand, bool>
{
    private readonly IRailwayDbContext _db;

    public CreateTicketsCommandHandler(IRailwayDbContext db) => _db = db;

    private const double DistancePriceCoefficient = 1.2;

    private const int TicketsPerJourney = 60;

    public async Task<bool> Handle(CreateTicketsCommand request, CancellationToken cancellationToken)
    {
        var journey = await _db.Journeys
            .Include(j => j.CityDeparture)
            .Include(j => j.CityArrival)
            .Where(j => j.Id == request.JourneyId)
            .FirstOrDefaultAsync(cancellationToken);

        if (journey is null)
        {
            throw new Exception($"Journey with id = \'{request.JourneyId}\' is not found in the database!");
        }

        var departure = journey.CityDeparture;

        var arrival = journey.CityArrival;

        var distance = Geo.GetDistance(departure.Latitude, departure.Longitude, arrival.Latitude, arrival.Longitude);

        var tickets = new List<Ticket>();
        
        for (int i = 1; i < TicketsPerJourney + 1; i++)
        {
            tickets.Add(new Ticket
            {
                Place = i,
                Price = (decimal)(distance * DistancePriceCoefficient),
                JourneyId = journey.Id,
            });
        }

        try
        {
            await _db.Tickets.AddRangeAsync(tickets, cancellationToken);
            
            await _db.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save tickets: {ex.Message}");
            
            return false;
        }
    }
}