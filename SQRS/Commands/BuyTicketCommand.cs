using exam2.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace exam2.SQRS.Commands;

public record BuyTicketCommand(int JourneyId) : IRequest<bool>;

public class BuyTicketCommandHandler : IRequestHandler<BuyTicketCommand, bool>
{
    private readonly IRailwayDbContext _db;

    public BuyTicketCommandHandler(IRailwayDbContext db) => _db = db;

    public async Task<bool> Handle(BuyTicketCommand request, CancellationToken cancellationToken)
    {
        var journey = await _db.Journeys
            .Include(j => j.Tickets)
            .Where(j => j.Id == request.JourneyId)
            .FirstOrDefaultAsync(cancellationToken);

        if (journey is null)
        {
            throw new Exception($"Journey with id = \'{request.JourneyId}\' is not found in the database!");
        }

        var availableTicket = journey.Tickets
            .Where(t => !t.IsPurchased)
            .MinBy(t => t.Place);

        if (availableTicket is null)
        {
            return false;
        }

        availableTicket.IsPurchased = true;

        _db.Tickets.Update(availableTicket);

        await _db.SaveChangesAsync(cancellationToken);

        return true;
    }
}