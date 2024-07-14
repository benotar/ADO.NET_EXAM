using exam2.Data;
using exam2.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace exam2.SQRS.Commands;

public record CreateJourneyCommand(string CityDeparture, string CityArrival, DateTime DispatchAt)
    : IRequest<Journey>;

public class CreateJourneyCommandHandler : IRequestHandler<CreateJourneyCommand, Journey>
{
    private readonly IRailwayDbContext _db;

    public CreateJourneyCommandHandler(IRailwayDbContext db) => _db = db;

    public async Task<Journey> Handle(CreateJourneyCommand request, CancellationToken cancellationToken)
    {
        var existingDepartureCity = await _db.Cities.Where(c => c.Name == request.CityDeparture)
            .FirstOrDefaultAsync(cancellationToken);

        if (existingDepartureCity is null)
        {
            throw new Exception("City Departure is not found in the database!");
        }
        
        var existingArrivalCity = await _db.Cities.Where(c => c.Name == request.CityArrival)
            .FirstOrDefaultAsync(cancellationToken);
        
        if (existingArrivalCity is null)
        {
            throw new Exception("City Arrival is not found in the database!");
        }

        if (existingDepartureCity.Id == existingArrivalCity.Id)
        {
            throw new Exception("The city of departure cannot be the city of arrival at the same time!");
        }
        
        if (request.DispatchAt == DateTime.MinValue)
        {
            throw new Exception("The date of dispatch must not be empty!");
        }

        var journey = new Journey
        {
            CityDepartureId = existingDepartureCity.Id,
            CityArrivalId = existingArrivalCity.Id,
            DispatchAt = request.DispatchAt
        };

        await _db.Journeys.AddAsync(journey, cancellationToken);

        await _db.SaveChangesAsync(cancellationToken);
        
        return journey;
    }
}