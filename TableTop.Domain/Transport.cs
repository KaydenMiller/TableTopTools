namespace TableTop.Domain;

public interface ITransport
{
    public float MaxWight { get; set; }
    public Volume AvailableVolume { get; set; }
    public TravelSpeed TravelSpeed { get; set; }
}

public class CoveredWagon : ITransport
{
    public float MaxWight { get; set; } = 2204.62f * 4; /* tons */
    public Volume AvailableVolume { get; set; } = new(10, 4, 6);
    public TravelSpeed TravelSpeed { get; set; } = new(2);
}