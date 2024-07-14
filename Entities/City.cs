using System.Text.Json.Serialization;

namespace exam2.Entities;

public class City : BaseEntity
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    [JsonIgnore]
    public ICollection<Journey> JourneysDeparting { get; set; } = new List<Journey>();
    [JsonIgnore]
    public ICollection<Journey> JourneysArriving { get; set; } = new List<Journey>();

}