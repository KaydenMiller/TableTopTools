using TableTop.Domain;

namespace TableTop.Economy.Application;

public class Application
{
    public const uint TICK_RATE = 1;
    public uint Day = 0;
    
    
    public List<City> Cities = [
        new City()
        {
            Name = "Markain",
            Coordinate = new Coordinate(0, 0),
            Population = 10,
            StartingWealth = 100 * 10
        },
        new City()
        {
            Name = "Draden",
            Coordinate = new Coordinate(1, 0),
            Population = 10,
            StartingWealth = 100 * 10
        }
    ];

    public void SimulationLoop()
    {
        Day += 1;
    }

}