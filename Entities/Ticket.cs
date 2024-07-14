namespace exam2.Entities;

public class Ticket : BaseEntity
{
    public int JourneyId { get; set; }
    public int Place { get; set; }
    public decimal Price { get; set; }
    
    public bool IsPurchased { get; set; } = false;
    public Journey Journey { get; set; }
}
