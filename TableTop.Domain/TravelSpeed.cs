namespace TableTop.Domain;

public struct TravelSpeed
{
    public uint Distance { get; init; }
    public uint TimeframeInHours { get; init; }
    
    public TravelSpeed(uint distance, uint timeframe = 1)
    {
        Distance = distance;
        TimeframeInHours = timeframe;
    }
}