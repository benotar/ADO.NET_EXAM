namespace exam2.Entities;

public class City : BaseEntity
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public ICollection<Journey> JourneysDeparting { get; set; } = new List<Journey>();
    public ICollection<Journey> JourneysArriving { get; set; } = new List<Journey>();

}