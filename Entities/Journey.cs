namespace exam2.Entities;

public class Journey : BaseEntity
{
    public int CityDepartureId { get; set; }
    public City CityDeparture { get; set; }
    
    public int CityArrivalId { get; set; }
    public City CityArrival { get; set; }
    
    public DateTime DateDispatch { get; set; }

    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}