namespace exam2.Entities;

public class Ticket : BaseEntity
{
    public int JourneyId { get; set; }
    public Journey Journey { get; set; }
    public int Seat { get; set; }
    public decimal Price { get; set; }
    public bool IsPurchased { get; set; } = false;
}