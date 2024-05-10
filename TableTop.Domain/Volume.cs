namespace TableTop.Domain;

public struct Volume
{
    public float X { get; init; }
    public float Y { get; init; }
    public float Z { get; init; }

    public Volume(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public float VolumetricWeight(float dimFactor)
    {
        return (X * Y * Z) / dimFactor;
    }
}