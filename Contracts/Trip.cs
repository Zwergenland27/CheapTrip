namespace CheapTrip.Contracts;

public class Trip
{
    public Station Origin { get; set; } = null!;

    public Station Destination { get; set; } = null!;

    public DateTime Departure { get; set; } = DateTime.Now;
}
