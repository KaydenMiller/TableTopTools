namespace TableTop.Domain;

public struct Coordinate
{
    public float X { get; init; }
    public float Y { get; init; }

    public Coordinate(float x, float y)
    {
        X = x;
        Y = y;
    }
}