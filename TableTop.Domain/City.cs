namespace TableTop.Domain;

public interface ILocation
{
    public Coordinate Coordinate { get; set; }
}

public class City : ILocation
{
    public string Name { get; set; }
    public Coordinate Coordinate { get; set; }
}