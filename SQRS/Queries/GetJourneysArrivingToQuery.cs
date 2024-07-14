using exam2.Data;
using exam2.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace exam2.SQRS.Queries;

public record GetJourneysArrivingToQuery(string cityName) : IRequest<IEnumerable<Journey>>;

public class GetJourneysArrivingToQueryHandler : IRequestHandler<GetJourneysArrivingToQuery, IEnumerable<Journey>>
{
    private readonly IRailwayDbContext _db;

    public GetJourneysArrivingToQueryHandler(IRailwayDbContext db) => _db = db;

    public async Task<IEnumerable<Journey>> Handle(GetJourneysArrivingToQuery request,
        CancellationToken cancellationToken)
    {
        var city = await _db.Cities
            .Include(c => c.JourneysDeparting)
            .Include(c => c.JourneysArriving)
            .Where(c => c.Name.ToLower() == request.cityName.ToLower())
            .FirstOrDefaultAsync(cancellationToken);

        if (city is null)
        {
            throw new Exception($"City '{request.cityName}' not found in the database!");
        }

        return city.JourneysArriving;
    }
}